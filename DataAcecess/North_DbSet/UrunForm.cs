using Microsoft.EntityFrameworkCore;
using North_DbSet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace North_DbSet
{
    public partial class UrunForm : Form
    {
        private NorthwindContext _dbContext = new NorthwindContext();
        public UrunForm()
        {
            InitializeComponent();
        }

        private void UrunForm_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            lstProducts.DataSource = _dbContext.Products
                .Include(x=>x.Category)
                .Include(x => x.Supplier)
                .ToList();
            //lstProducts.DisplayMember = "ProductName"; // Product partailında tostring(9 ile ezdik.

            cmbCategory.DataSource = _dbContext.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";

            cmbSupplier.DataSource = _dbContext.Suppliers.ToList();
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "SupplierId";
        }
       
        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem == null) return;

            _selectedProduct = (Product)lstProducts.SelectedItem;
            txtProductName.Text = _selectedProduct.ProductName;
            nUnitPrice.Value= _selectedProduct.UnitPrice.GetValueOrDefault();
            cbDiscontinued.Checked = _selectedProduct.Discontinued;

            cmbCategory.SelectedItem=_selectedProduct.Category;
            cmbSupplier.SelectedItem=_selectedProduct.Supplier;
        }
        private Product _selectedProduct;
        private Category _selectedCategory;
        private Supplier _selectedSupplier;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(cmbCategory.SelectedItem!= null)
                _selectedCategory = (Category)cmbCategory.SelectedItem;
            else
                _selectedCategory = null;

            if (cmbSupplier.SelectedItem != null)
                _selectedSupplier = cmbSupplier.SelectedItem as Supplier;
            else
                cmbSupplier = null;

            var yeni = new Product()
            {
                UnitPrice = nUnitPrice.Value,
                ProductName = txtProductName.Text,
                Discontinued = cbDiscontinued.Checked,
                CategoryId=_selectedCategory==null ?null :_selectedCategory.CategoryId,
                SupplierId=_selectedSupplier?.SupplierId// Üstteki ifadenin kısayol yazılımı ?. null değilse ıd yi null ise null ata

            };

            try
            {
                _dbContext.Products.Add(yeni);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ListeyiDoldur();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var product=_dbContext.Products
                .Include(x=> x.OrderDetails)
                .FirstOrDefault(x=>x.ProductId== _selectedProduct.ProductId);

            if (product == null) return;

            if(product.OrderDetails.Any())
            {
                MessageBox.Show($"{product.ProductName} isimli ürün süparişlerde kullanıldığından silemezsiniz.");
                return;
            }

            var dialogResult = MessageBox.Show($"{product.ProductName} isimli ürünü silmel istiyormusunuz?", "Ürün silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult==DialogResult.Yes)
            {
                try
                {
                    _dbContext.Products.Remove(product);
                    _dbContext.SaveChanges();

                }
                catch (Exception ex)
                {
                    _dbContext = new NorthwindContext();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ListeyiDoldur();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_selectedProduct == null) return;

            if (cmbCategory.SelectedItem != null)
                _selectedCategory = (Category)cmbCategory.SelectedItem;
            else
                _selectedCategory = null;

            if (cmbSupplier.SelectedItem != null)
                _selectedSupplier = cmbSupplier.SelectedItem as Supplier;
            else
                cmbSupplier = null;
            try
            {
                //var product = _dbContext.Products.Find(_selectedProduct.ProductId);// Find() PK üzerinde calışıyor. 
                var product = _dbContext.Products.First(x=>x.ProductId==_selectedProduct.ProductId);// First() lambda expression ile istenilen değer aranıyor. 
                product.ProductName = txtProductName.Text;
                product.UnitPrice = nUnitPrice.Value;
                product.Discontinued = cbDiscontinued.Checked;
                product.SupplierId = _selectedSupplier?.SupplierId;
                product.CategoryId = _selectedCategory?.CategoryId;
              

                _dbContext.Products.Update(product);

                _dbContext.SaveChanges();

            }
            catch (Exception ex)
            {

                _dbContext = new NorthwindContext();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ListeyiDoldur();
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAra.Text))
            {
                lstProducts.DataSource = _dbContext.Products.ToList();
            }
            else
            {
                var result = _dbContext.Products.Where(x => x.ProductName.Contains(txtAra.Text.ToUpper())).ToList();
                lstProducts.DataSource = result;
                this.Text = $"{result.Count} Adet ürün Listelenmektedir.";
            }
        }
    }
}

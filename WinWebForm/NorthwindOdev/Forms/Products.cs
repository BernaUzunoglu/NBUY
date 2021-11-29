using NorthwindOdev.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindOdev.Forms
{
    public partial class Products : Form
    {
        NorthwindContext _dbContext = new NorthwindContext();
        public Products()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dtgridUrun.DataSource = _dbContext.Products.ToList();
            dtgridUrun.Rows[dtgridUrun.RowCount - 1].Selected = true;
            
        }

        private void Products_Load(object sender, EventArgs e)
        {
            cmbKategori.DataSource = _dbContext.Categories.ToList();
            cmbKategori.ValueMember = "CategoryId";
            cmbKategori.DisplayMember = "CategoryName";

            cmbTedar.DataSource = _dbContext.Suppliers.ToList();
            cmbTedar.ValueMember = "SupplierID";
            cmbTedar.DisplayMember = "CompanyName";

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Product _product = new Product();
            _product.ProductName = txt_UrunAdi.Text;
            Supplier selectedSuplier =cmbTedar.SelectedItem as Supplier;
            _product.SupplierId = Int32.Parse(selectedSuplier.SupplierId.ToString());
            Category selectedCategory = cmbKategori.SelectedItem as Category;
           _product.CategoryId = Int32.Parse(selectedCategory.CategoryId.ToString());
            _product.CategoryId= Int32.Parse(cmbKategori.SelectedValue.ToString());
            _product.QuantityPerUnit=txtBirim.Text;
            _product.UnitPrice=Convert.ToDecimal(txtFiyat.Text);
            _product.UnitsInStock=Convert.ToInt16(txtStok.Text);
            _product.UnitsOnOrder=Convert.ToInt16(txtSiparis.Text); 
            _product.Discontinued=chxBxDurdur.Checked;


            _dbContext.Products.Add(_product);
            _dbContext.SaveChanges();
            MessageBox.Show("Ekleme işlemi gerçekleşirildi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Product seciliurun = (Product)this.dtgridUrun.CurrentRow.DataBoundItem;
            _dbContext.Products.Remove(seciliurun);
            _dbContext.SaveChanges();
            MessageBox.Show("Silme işlemi gerçekleştirildi.");
        }

        private void dtgridUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgridUrun.SelectedRows == null) return; //index çaýþtýðýnda null gelebilir. Hata verme.
            Product seciliurun = (Product)this.dtgridUrun.CurrentRow.DataBoundItem;
            txt_UrunAdi.Text = seciliurun.ProductName;
            //cmbKategori.Text= secilikurun.Supplier
            txtBirim.Text=seciliurun.QuantityPerUnit.ToString();
            txtFiyat.Text=seciliurun.UnitPrice.ToString();  
            txtStok.Text=seciliurun.UnitsInStock.ToString();   
            txtSiparis.Text=seciliurun.UnitsOnOrder.ToString();   
            txtYeniSiparis.Text=seciliurun.ReorderLevel.ToString();
            chxBxDurdur.Checked=seciliurun.Discontinued;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Product seciliurun = (Product)this.dtgridUrun.CurrentRow.DataBoundItem;
            seciliurun.ProductName = txt_UrunAdi.Text;
            Supplier selectedSuplier = cmbTedar.SelectedItem as Supplier;
            seciliurun.SupplierId = Int32.Parse(selectedSuplier.SupplierId.ToString());
            Category selectedCategory = cmbKategori.SelectedItem as Category;
            seciliurun.CategoryId = Int32.Parse(selectedCategory.CategoryId.ToString());
            seciliurun.CategoryId = Int32.Parse(cmbKategori.SelectedValue.ToString());
            seciliurun.QuantityPerUnit = txtBirim.Text;
            seciliurun.UnitPrice = Convert.ToDecimal(txtFiyat.Text);
            seciliurun.UnitsInStock = Convert.ToInt16(txtStok.Text);
            seciliurun.UnitsOnOrder = Convert.ToInt16(txtSiparis.Text);
            seciliurun.Discontinued = chxBxDurdur.Checked;

            MessageBox.Show("Güncelleme işlemi gerçekleştirildi");
        }

        private void btnCalisanGit_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();
            employee.Show();
        }
    }
}

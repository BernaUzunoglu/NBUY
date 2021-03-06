using North_DbSet.Models;
using North_DbSet.ViewModels;
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
    public partial class SiparisForm : Form
    {
        private NorthwindContext _dbContext = new NorthwindContext();
        public SiparisForm()
        {
            InitializeComponent();
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            lstProducts.DataSource = UrunAra();
            cmbEmployee.DataSource=_dbContext.Employees.OrderBy(x=>x.FirstName).ThenBy(x=>x.LastName).ToList() ;
            cmbShippers.DataSource = _dbContext.Shippers.ToList();
            cmbShippers.DisplayMember = "CompanyName";
            cmbCustomers.DataSource = _dbContext.Customers.OrderBy(x => x.CompanyName).ToList();
            cmbCustomers.DisplayMember = "CompanyName";
        }



        private List<Product>UrunAra(Func<Product,bool> predicate=null)
        {
            return predicate==null ? _dbContext.Products.OrderBy(x => x.ProductName).ToList() :
                _dbContext.Products.Where(predicate).OrderBy(x => x.ProductName).ToList();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string text=txtAra.Text.ToLower();
            lstProducts.DataSource=UrunAra(x=>x.ProductName.ToLower().Contains(text));
        }

        public List<SepetViewModel> _sepet = new List<SepetViewModel>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem == null) return;

            var urun = lstProducts.SelectedItem as Product;

            var sepetUrun = _sepet.FirstOrDefault(x=>x.Urun.ProductId==urun.ProductId);

            if(sepetUrun==null)
            {
                _sepet.Add(new SepetViewModel
                {
                    Urun = urun,
                    Adet = 1
                });
                
            }
            else
            {
                sepetUrun.Adet++;
            }
            SepetiDoldur();
        }

        private void SepetiDoldur()
        {

            var toplamFiyat = _sepet.Sum(x=>x.AraToplam);
            lblToplam.Text = $"Toplam:{toplamFiyat:c2}";

            lstCart.Columns.Clear();
            lstCart.Items.Clear();
            lstCart.MultiSelect = false;
            lstCart.FullRowSelect= true;
            lstCart.View = View.Details;

            lstCart.Columns.Add("Adet");
            lstCart.Columns.Add("Ürün");
            lstCart.Columns.Add("Ara Toplam");

            foreach (var item in _sepet)
            {
                ListViewItem viewItem = new ListViewItem(item.Adet.ToString());
                viewItem.Tag=item;
                viewItem.SubItems.Add(item.Urun.ProductName);
                viewItem.SubItems.Add($"{item.AraToplam:c2}");
                lstCart.Items.Add(viewItem);
            }
            lstCart.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedItems.Count == 0) return;

            var secili = lstCart.SelectedItems[0].Tag as SepetViewModel;

            if (secili.Adet == 1)
            {
                _sepet.Remove(secili);
            }
            else
            {
                secili.Adet--;
            }
            SepetiDoldur();

        }

        private void btnArttır_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedItems.Count == 0) return;

            var secili = lstCart.SelectedItems[0].Tag as SepetViewModel;
            secili.Adet++;
            SepetiDoldur();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (!_sepet.Any()) return;
            //birbiriyle ilişkili tablolarla çalışırken transaction kullanılmalı

            using (var tran = _dbContext.Database.BeginTransaction()) //using ifadeler garbage collector tarafından işlem ibitnce temizlenir
            {

                var customer = cmbCustomers.SelectedItem as Customer;
                var employee = cmbEmployee.SelectedItem as Employee;
                var shipper = cmbShippers.SelectedItem as Shipper;


                try
                {
                    var order = new Order()
                    {
                        CustomerId = customer?.CustomerId,
                        EmployeeId = employee?.EmployeeId,
                        ShipVia = shipper?.ShipperId,
                        Freight = nFreight?.Value,
                        OrderDate = DateTime.Now,
                        RequiredDate = dtpRequiredDate.Value,
                        ShipAddress = txtShipAdress.Text,
                        ShipCity = txtshipCity.Text,
                        ShipName = txtShipName.Text,
                        ShipPostalCode = txtShipPostalCode.Text,
                        ShipRegion = txtShipRegion.Text,
                        ShipCountry = txtShipCountry.Text
                    };
                    _dbContext.Orders.Add(order);
                    _dbContext.SaveChanges();

                    foreach (var item in _sepet)
                    {
                        if (item.Urun.ProductId == 1)
                            throw new Exception("Chai satılmıyor.");

                        _dbContext.OrderDetails.Add(new OrderDetail
                        {
                            Discount = 0,
                            OrderId = order.OrderId,
                            ProductId = item.Urun.ProductId,
                            Quantity = item.Adet,
                            UnitPrice = item.Urun.UnitPrice.GetValueOrDefault()
                        });

                    }
                    tran.Commit();
                    MessageBox.Show($"{_sepet.Sum(x => x.AraToplam) + order.Freight:c2} tutarındaki siparişiniz {order.OrderId} nolu siparişiniz başarıyla tamamlanmıştır. ");
                    _sepet = new List<SepetViewModel>();
                    SepetiDoldur();

                }
                catch (Exception ex)
                {

                    tran.Rollback();
                    MessageBox.Show("Sipariş işleminizde bir hata oluştu." + ex.Message);
                }
            }
        }
    }
}

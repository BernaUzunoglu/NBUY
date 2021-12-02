using Microsoft.EntityFrameworkCore;
using North_DbSet.Models;
using North_DbSet.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace North_DbSet
{
    public partial class Form2 : Form
    {
       
        private NorthwindContext _dbContext = new NorthwindContext();
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            var query1 = _dbContext.Categories.Select(x => new CategoryViewModel()
            {
                CategoryName = x.CategoryName,
                Description = x.Description,
                Picture = x.Picture,
                ProductCount = x.Products.Count
            }).ToList();
            dgvNorth.DataSource = query1;


            var query2 = from cat in _dbContext.Categories
                         join prod in _dbContext.Products on cat.CategoryId equals prod.CategoryId
                         where prod.UnitPrice > 20
                         select new
                         {
                             cat.CategoryName,
                             prod.ProductName,
                             prod.UnitPrice
                         };
            dgvNorth.DataSource = query2
                .OrderBy(x => x.CategoryName)
                    .ThenByDescending(x => x.UnitPrice)
                    .ToList();


            var query3 = _dbContext.Products.Select(x => new
            {
                x.Category.CategoryName,
                x.ProductName,
                x.UnitPrice

            }).OrderBy(x => x.CategoryName)
                .ThenByDescending(x => x.UnitPrice)
                .ToList();
            dgvNorth.DataSource = query3;

            // 1 Federal shipping ile taşınmış ve Nancy' nin almış olduğu sipariişleri gösteriniz

            var query4 = from emp in _dbContext.Employees
                         join ord in _dbContext.Orders on emp.EmployeeId equals ord.EmployeeId
                         join ship in _dbContext.Shippers on ord.ShipVia equals ship.ShipperId
                         where emp.FirstName == "Nancy" && ship.CompanyName == "Federal Shipping"
                         select new
                         {
                             emp.FirstName,
                             emp.LastName,
                             ord.OrderId,
                             ord.ShipVia,
                             ship.ShipperId,
                             ship.CompanyName
                         };
            dgvNorth.DataSource = query4
                .OrderBy(x => x.OrderId)
                    .ToList();

            //2 Müşteri Adı, onaylayan çalışan adı,aldığı ürünlerin adını listeleyin Müşterim çalışanım kaçartane üürün satmıs

            var query5 = from cus in _dbContext.Customers
                         join ord in _dbContext.Orders on cus.CustomerId equals ord.CustomerId
                         join emp in _dbContext.Employees on ord.EmployeeId equals emp.EmployeeId
                         join ordDet in _dbContext.OrderDetails on ord.OrderId equals ordDet.OrderId
                         join prod in _dbContext.Products on ordDet.ProductId equals prod.ProductId
                         select new
                         {
                             cus.ContactName,
                             emp.FirstName,
                             prod.ProductName

                         };
            dgvNorth.DataSource = query5.ToList();

            //3   01.01.1998 tarihinden sonra Siparis veren müşterilerin isimlerini ve sipariş tarihlerini listeleyiniz.

            var query6 = from cus in _dbContext.Customers
                         join ord in _dbContext.Orders on cus.CustomerId equals ord.CustomerId
                         where ord.OrderDate > new DateTime(1998, 01, 01)
                         select new
                         {
                             cus.ContactName,
                             ord.OrderDate
                         };
            dgvNorth.DataSource = query6.ToList();


            //4  10248 nolu sipariş hangi kargo şirketi ile gönderilmiştir.

            var query7 = from ord in _dbContext.Orders
                         join ship in _dbContext.Shippers on ord.ShipVia equals ship.ShipperId
                         where ord.OrderId == 10248
                         select ship;

            dgvNorth.DataSource = query7.ToList();


            //5  Tofu isimli ürün alınan siparişlerin sipariş numaralarını listeleyiniz

            var query8 = from prod in _dbContext.Products
                         join ordDet in _dbContext.OrderDetails on prod.ProductId equals ordDet.ProductId
                         where prod.ProductName == "Tofu"
                         select new
                         {
                             prod.ProductName,
                             ordDet.OrderId
                         };


            dgvNorth.DataSource = query8.ToList();


            // 6  Dumon ve alfkı müşterinin aldığı 1 ID li çalışanımın onayladığı 1 veya 3 nolu kargo firmasıyla taşınmış siparişleri getirin

            var query9 = from ord in _dbContext.Orders
                         where (ord.CustomerId.Contains("DUMON") || ord.CustomerId.Contains("ALFKI"))
                         && ord.EmployeeId == 1 && (ord.ShipVia == 1 || ord.ShipVia == 3)
                         select ord;

            dgvNorth.DataSource = query9.ToList();


            // 7   Ülkelerden kaçar tane var

            var query10 = _dbContext.Customers.GroupBy(c => c.Country).
                Select(g => new
                {
                    g.Key,
                    Adet = g.Count()
                });
            dgvNorth.DataSource = query10.ToList();



            // 8  Siparişleri sipariş numarası ve sipariş toplam tutarı olarak listeleyiniz

            var query11 = _dbContext.OrderDetails.GroupBy(x => x.OrderId).
                Select(x => new
                {
                    x.Key,
                    Tutar = x.Sum(s => Convert.ToInt32(1 - s.Discount) * s.UnitPrice * s.Quantity)

                });
            dgvNorth.DataSource = query11.ToList();

            // 9  Hangi üründen ne kadarlık sipariş edilmiş

            var query12 = from prod in _dbContext.Products
                          join ordDet in _dbContext.OrderDetails on prod.ProductId equals ordDet.ProductId
                          group new { prod, ordDet } by prod.ProductName into g
                          select new
                          {
                              UrunAdi = g.Key,
                              Tutar = g.Sum(s => Convert.ToInt32(1 - s.ordDet.Discount) * s.ordDet.UnitPrice * s.ordDet.Quantity)

                          };
            dgvNorth.DataSource = query12.ToList();



            //10   HENÜZ ULAŞMAMIŞ SİPARİŞLERİN TOPLAM MALİYETİ NEDİR
            var query13 = from ordDet in _dbContext.OrderDetails
                          join ord in _dbContext.Orders on ordDet.OrderId equals ord.OrderId
                          where !ord.ShippedDate.HasValue
                          group ordDet by ordDet.OrderId into orderId
                          select new
                          {
                              OrderId = orderId.Key,
                              Tutar = orderId.Sum(s => Convert.ToInt32(1 - s.Discount) * s.UnitPrice * s.Quantity)
                          };
            dgvNorth.DataSource = query13.ToList();

            var query14 = _dbContext.Products
                .Include(x => x.Supplier)
                .Include(x => x.Category)
                .Select(x => new
                {
                    x.ProductName,
                    x.UnitPrice,
                    x.Supplier.CompanyName,
                    x.Category.CategoryName
                }).ToList();

            var query15 = _dbContext.Products
              .Include(x => x.Supplier)
              .Include(x => x.Category)
              .Include(x => x.OrderDetails)
              .ThenInclude(x => x.Order)
              .ThenInclude(x => x.ShipViaNavigation);
            //.Select(x => new
            //{
            //    x.ProductName,
            //    x.UnitPrice,
            //    x.Supplier.CompanyName,
            //    x.OrderDetails.Count
            //}).ToList();

            var querystring = query15.ToQueryString();// IQueryable tipinde değer veriyor Verinin nasıl geleceğini belirlemiş oluyooruz
            var qq = querystring.ToList();

            //RaporuGoster();

            var query17 = from cat in _dbContext.Categories
                          join prod in _dbContext.Products on cat.CategoryId equals prod.CategoryId
                          join sup in _dbContext.Suppliers on prod.SupplierId equals sup.SupplierId
                          group new { cat, prod, sup } by new { cat.CategoryName, sup.CompanyName } into cats
                          select new
                          {
                              CategoryName = cats.Key.CategoryName,
                              CompanyName = cats.Key.CompanyName,
                              Say = cats.Count()
                          };
            dgvNorth.DataSource = query17
                .OrderBy(x => x.CategoryName)
                .ThenByDescending(x => x.Say)
                .ToList();

            //1.YOL
            var query18 = from cat in _dbContext.Categories
                          join prod in _dbContext.Products on cat.CategoryId equals prod.CategoryId
                          join sup in _dbContext.Suppliers on prod.SupplierId equals sup.SupplierId
                          group new { cat, prod, sup } by new { cat.CategoryName, sup.CompanyName } into cats
                          select new
                          {
                              CategoryName = cats.Key.CategoryName,
                              CompanyName = cats.Key.CompanyName,
                              Cost = cats.Sum(x => x.prod.UnitPrice * x.prod.UnitsInStock)
                          };
            dgvNorth.DataSource = query18
                .OrderBy(x => x.CategoryName)
                .ThenByDescending(x => x.Cost)
                .ToList();

            //2 . YOL Lambda expression
            var query19 = _dbContext.Products
                .Include(x => x.Category)
                .Include(x => x.Supplier)
                .GroupBy(x => new { x.Category.CategoryName, x.Supplier.CompanyName })
                .Select(x => new
                {
                    x.Key.CategoryName,
                    x.Key.CompanyName,
                    Cost = x.Sum(p => p.UnitsInStock * p.UnitPrice)
                });

            dgvNorth.DataSource = query19
               .OrderBy(x => x.CategoryName)
               .ThenByDescending(x => x.Cost)
               .ToList();

            var query20 = from prod in _dbContext.Products
                          join ordDet in _dbContext.OrderDetails on prod.ProductId equals ordDet.ProductId
                          group new { prod, ordDet } by prod.ProductName into g
                          select new ProductNameTotalViewModel
                          {
                              UrunAdi = g.Key,
                              //Tutar = $"{g.Sum(s => (decimal)(1 - s.ordDet.Discount) * s.ordDet.UnitPrice * s.ordDet.Quantity).ToString("#,##0.00", CultureInfo.CurrentCulture)}"
                              Tutar = Math.Round(g.Sum(s => (decimal)(1 - s.ordDet.Discount) * s.ordDet.UnitPrice * s.ordDet.Quantity), 2)
                          };
            dgvNorth.DataSource = query20.ToList();

            var query21 = _dbContext.OrderDetails
                .Include(x => x.Product) //joinler
                .GroupBy(x => new { x.Product.ProductName })
                .Select(x => new ProductNameTotalViewModel
                {
                    UrunAdi = x.Key.ProductName,
                    Tutar =Math.Round(x.Sum(od => (decimal)(1 - od.Discount) * od.Quantity * od.UnitPrice),2)
                });
            dgvNorth.DataSource = query21
                .OrderByDescending(x => x.Tutar)
                .ToList();
            dgvNorth.DataSource = query21.ToList();


        }
        private int _offset = 0, _pageSize = 10, _maxPage = 0;

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (_offset + 1 == _maxPage) return;
            _offset++;
            RaporuGoster();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (_offset == 0) return;
            _offset--;
            RaporuGoster();
        }
        private void RaporuGoster()
        {
            lblSayfa.Text = $"{ _offset + 1}";
            var query16 = _dbContext.Products
              .Include(x => x.Supplier)
              .Include(x => x.Category)
              .Select(x => new
              {
                  x.Category.CategoryName,
                  x.ProductName,
                  x.UnitPrice,
                  x.Supplier.CompanyName
              });

            if (_maxPage == 0)
            {
                _maxPage = (int)Math.Ceiling(query16.Count() / Convert.ToDouble(_pageSize));
            }

            var result = query16
              .OrderBy(x => x.CategoryName)
              .Skip(_offset * _pageSize)
              .Take(_pageSize)
              .ToList();
            dgvNorth.DataSource = result;
            dgvNorth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            query16.Count(x => x.UnitPrice > 20);
            query16.Sum(x => x.UnitPrice);
            query16.Average(x => x.UnitPrice);
            query16.Max(x => x.UnitPrice);
            query16.Min(x => x.UnitPrice);


            query16.Any();// var mı 
                          //query16.All();//Yokluğu





        }


    }
}

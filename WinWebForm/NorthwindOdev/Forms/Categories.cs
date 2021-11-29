using NorthwindOdev.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindOdev.Forms
{
    public partial class Categories : Form
    {
        NorthwindContext _dbContext = new NorthwindContext();
        public Categories()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //var liste=_dbContext.Categories.
           
            dtgvKategori.DataSource = _dbContext.Categories.ToList();
            dtgvKategori.Rows[dtgvKategori.RowCount - 1].Selected = true;
          

            //Include()

            var liste = _dbContext.Categories.ToList();


            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Id");
            listView1.Columns.Add("CategoryName");
            listView1.Columns.Add("Description");
            listView1.View = View.Details;
            
            foreach (Category item in liste)
            {
                ListViewItem viewItem = new ListViewItem(item.CategoryId.ToString());
                viewItem.SubItems.Add(item.CategoryName);
                viewItem.SubItems.Add(item.Description);
                listView1.Items.Add(viewItem);
                //listView1.Items.Add(Image.FromStream(new MemoryStream(item.Picture));

            }
        }
        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            Category _category = new Category();
            
            _category.CategoryName = txtKategoriAdi.Text;
            _category.Description = txtKategoriTanım.Text;
            if (pboxResim.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pboxResim.Image.Save(resimStream, ImageFormat.Jpeg);

                _category.Picture = resimStream.ToArray();
            }
            _dbContext.Categories.Add(_category);
            _dbContext.SaveChanges();
            MessageBox.Show("Ekleme işlemi gerçekleşirildi.");

        }

        private void pboxResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir fotoğraf seçiniz";
            dialog.Filter = "Resim Dosyaları |*.jpeg; *.jpg; *.png; *.jfif";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pboxResim.ImageLocation = dialog.FileName;
            }
        }
        private void Categories_Load(object sender, EventArgs e)
        {
        }

        private void dtgvKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dtgvKategori.ClearSelection();
            if (dtgvKategori.SelectedRows == null) return; //index çaýþtýðýnda null gelebilir. Hata verme.
            Category secilikategori = (Category)this.dtgvKategori.CurrentRow.DataBoundItem;
            txtKategoriAdi.Text = secilikategori.CategoryName;
            txtKategoriTanım.Text = secilikategori.Description;
            //cmbKategori.SelectedValue = seciliUrun.UrunKategori;

            if (secilikategori.Picture != null)
            {

                MemoryStream stream = new MemoryStream(secilikategori.Picture);
                //Bitmap image = new Bitmap(stream);
                pboxResim.Image = Image.FromStream(stream);
            }

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Category secilikategori = (Category)this.dtgvKategori.CurrentRow.DataBoundItem;
            secilikategori.CategoryName = txtKategoriAdi.Text;
            secilikategori.Description = txtKategoriTanım.Text;
            if (pboxResim.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pboxResim.Image.Save(resimStream, ImageFormat.Jpeg);

                secilikategori.Picture = resimStream.ToArray();
            }
            _dbContext.SaveChanges();
            MessageBox.Show("Güncelleme işlemi gerçekleşirildi.");


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Category secilikategori = (Category)this.dtgvKategori.CurrentRow.DataBoundItem;
            _dbContext.Categories.Remove(secilikategori);
            _dbContext.SaveChanges();
            MessageBox.Show("Silme işlemi gerçekleştirildi.");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAra.Text))
            {
                dtgvKategori.DataSource = _dbContext.Categories.ToList();
            }
            else
            {
                var result = _dbContext.Categories.Where(x => x.CategoryName.Contains(txtAra.Text.ToUpper())).ToList();
                dtgvKategori.DataSource = result;
                this.Text = $"{result.Count} Adet kategori Listelenmektedir.";
            }

        }

        private void btnurunGit_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
            this.Hide();
        }

        //private void btnEkle_Click_1(object sender, EventArgs e)
        //{

        //}
    }
}


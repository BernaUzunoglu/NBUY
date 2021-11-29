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
    public partial class Employees : Form
    {
        NorthwindContext _dbContext = new NorthwindContext();
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            cmbBolgeAcıklama.DataSource=_dbContext.Territories.ToList();
            cmbBolgeAcıklama.ValueMember = "TerritoryID";
            cmbBolgeAcıklama.DisplayMember = "TerritoryDescription";

            cmbBolgeAcıklama.SelectedIndexChanged += (sender, args) => {

                var selectedBolgeler = ((ComboBox)sender).SelectedItem as Territory;
                cmbBolge.DataSource = null;
                cmbBolge.Items.Clear();
                if (selectedBolgeler != null)
                {
                    cmbBolge.DataSource = _dbContext.Regions.Where(p => p.RegionId == selectedBolgeler.RegionId).ToList();
                    cmbBolge.DisplayMember = "RegionDescription";
                    cmbBolge.ValueMember = "RegionId";
                }
            };
        }
    }
}

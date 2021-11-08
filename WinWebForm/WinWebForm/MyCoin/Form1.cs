using MyCoin.Models;
using MyCoin.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Symbol> _symbols = new List<Symbol>();
        private void Form1_Load(object sender, EventArgs e)
        {
            var result = new ExchangeInfoService().Result();// var dinamik bir tiptir. Metot propert instance ne ise run time da o şekilde değişken tipi olarak alıyor.

            _symbols = result.Symbols;
            _symbols = _symbols.Where(x => x.status == "TRADING").OrderBy(x => x.symbol).ToList();
            lstExchange.DataSource = _symbols;
            lstExchange.DisplayMember = nameof(Symbol.symbol);

            this.Text = $"{_symbols.Count} adet Coin listelenmektedir.";
            
            Console.WriteLine();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAra.Text))
                lstExchange.DataSource = _symbols;
            else
            {
                var result = _symbols.Where(x => x.symbol.Contains(txtAra.Text.ToUpper())).ToList();
                lstExchange.DataSource = result ;
                this.Text = $"{result.Count} adet Coin listelenmektedir.";
            }
            
        }

        private Symbol _seciliSymbol;
        private void lstExchange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstExchange.SelectedItem == null) return;

            _seciliSymbol = lstExchange.SelectedItem as Symbol;

            try
            {
                var result = new SymbolTickerService().Result(_seciliSymbol.symbol);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}

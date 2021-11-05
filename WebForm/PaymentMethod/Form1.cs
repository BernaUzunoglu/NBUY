using PaymentMethod.Models.Payment.Abstracts;
using PaymentMethod.Models.Payment.Managers;
using PaymentMethod.Models.Payment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         *Kısa bilgi==> int? a=null; nullable ifade demek yani int değer null olamaz ama bu terim ile nullable yapılabiliyor.
         */
        private int[] taksitler = new[] { 1, 2, 3, 6, 9, 12 };

        private decimal sepetTutari = new Random().Next(1000,10000);
        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_PaymentMethod.DataSource= Enum.GetNames(typeof(PaymentMethods));

            for (int i = 1; i < 13; i++)
            {
                cmbAy.Items.Add($"{i:00}");
            }

            //for (int i = DateTime.Now.Year; i <= DateTime.Now.Year+10; i++)
            //{
            //    cmbYil.Items.Add(i);
            //}

            for (DateTime i = DateTime.Now; i <= DateTime.Now.AddYears(10); i=i.AddYears(1))
            {
                //cmbYil.Items.Add(i.Year.ToString().Substring(2)); veya
                cmbYil.Items.Add($"{i:yy}");
            }
        }

        private Card yeniCard;

        private PaymentMethods method;
        private void cmb_PaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            method=Enum.Parse<PaymentMethods>(cmb_PaymentMethod.SelectedItem.ToString());
            PaymentMethods method2 = (PaymentMethods)Enum.Parse(typeof(PaymentMethods), cmb_PaymentMethod.SelectedItem.ToString()); // 2. YOL

            //yeniCard = yeniCard ?? new Card();// Bu ifade eğer null ise new ile kuullan değilse  yeniCard değişkenini kullan demek.
            yeniCard ??= new Card(); // null ise nesne üret değilse yeniCard değişkeni kullan

            lstTaksitler.Items.Clear();
            if (method == PaymentMethods.Debit)
            {
                lstTaksitler.Items.Add($"Tek Çekim - {sepetTutari:c2}");
            }
            else if(method== PaymentMethods.Credit)
            {
                foreach (int taksit in taksitler)
                {
                    lstTaksitler.Items.Add($"{taksit} X {(sepetTutari/taksit):c2}");
                }
            }

        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            IPayable paymentManager;// İnterface ile ulaşıyoruz çünkü en az bağımlılık bunda var daha sonra sistem duruma göre diğer bağlılıklara ulaşılıyor.

            switch (method)
            {
                case PaymentMethods.Credit:
                    paymentManager = new CreditPaymentManager();

                    CreditPayment payment = new CreditPayment();
                    payment.Comission = 1.12m;
                    payment.Inatallement = taksitler[lstTaksitler.SelectedIndex];
                    payment.CustomerId = "123";
                    payment.Total = sepetTutari;
                    payment.CardInfo = creditCardBox1.CardInfo; // İçeriği user kontrollerda kart içeriğinin Card sınıfı nesnesini kullanarak dolu getirdik         1. YOL

                    /*
                     * //// ---Textbox içerisinde ki kart bilgilerinin alma user control olmadan 2 .YOL  -----////
                     
                    payment.CardInfo = new Card()
                    {
                        //Year = 2021,
                        //CVC = txtCvv.Text,
                        //Mount = 11,
                        //NameSurname = txtAdSoyad.Text,
                        //Number = txtCardNumber.Text

                        /-----///UserControl içerisinde tanladığımız kendi propertilerimize eriştik.---- 3.YOL 

                        Year = int.Parse(creditCardBox1.Yil),
                        CVC = creditCardBox1.Cvv,
                        Mount = int.Parse(creditCardBox1.Ay),
                        NameSurname = creditCardBox1.AdSoyad,
                        Number = creditCardBox1.KartNo

                    }; */
                     paymentManager.Pay(payment);

                    break;
                case PaymentMethods.Debit:
                    paymentManager = new DebitPaymentManager();

                    DebitPayment payment2 = new DebitPayment();
                    payment2.Commission = 1.12m;
                    payment2.CustomerId = "123";
                    payment2.Total = sepetTutari;
                    payment2.CardInfo = new Card()
                    {
                        Year = 2021,
                        CVC = txtCvv.Text,
                        Mount = 11,
                        NameSurname = txtAdSoyad.Text,
                        Number = txtCardNumber.Text
                    };

                    paymentManager.Pay(payment2);
                    break;
                default:
                    return;

            }

            if (paymentManager.State ==MessageStates.Success)
            {
                MessageBox.Show("Ödemeniz başarı ile yapıldı.");
            }
        }

        private void creditCardBox1_AdSoyadHata(object sender, KeyPressEventArgs e)
        {
            ErrorProvider provider = new ErrorProvider(this);
            provider.SetError(creditCardBox1, $"Yanlış bir karekter girdiniz : {e.KeyChar}");
            provider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            //Thread.Sleep(1000);
            //provider.Clear();
            this.Text = $"Yanlış bir karekter girdiniz : {e.KeyChar}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdresDefteri
{
    //Classlar önünde hiçbirşey yazılmaz ise default internal olur
    class Kisi
    {
        /*
         * public
         * private
         * internal
         * protected
         * internal protected
         */


        //constructor
        /*Nesneler olusturulurken yapılması gereken işlemlerin yazıldığı alandır.
         */
        public Kisi()
        {
            this.OlusturulmaZamanı = DateTime.Now;
        }

        //Fields
        //Fieldler _ ile yazım tekniği ile yazılır.
        #region Fields
        private string _tcNo;
        private string _ad;
        private string _soyad;
        //private DateTime _dogumTarihi;
        #endregion

        //Encapsulation
        /*Class' ın propertilerini koruma işlemidir.
         * Amacı propertilere her class'ın erişimini engellemek ve bu sayede kontrolsüz manipulasyona izin vermemektir.
         * Private ve protected olarak tanımlanmış değişkenlerde encapsulation işlemi yapılmaktadır.
         */
        public string Ad
        {
            set // value 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new FormatException("Kişinin adı boş geçilemez");
                }

                foreach (char harf in value)
                {
                    if (char.IsDigit(harf))
                        throw new Exception("Kişinin adında rakam bulunamaz");
                    if (char.IsSymbol(harf) || char.IsControl(harf) || char.IsPunctuation(harf))
                        throw new Exception("Kişinin adında geçersiz karekterler bulunmaktadır.");
                }
                if (value.Length > 50 || value.Length < 2)
                    throw new Exception("Gİrilen ifade 50 karekterden fazla ve 2 karekterden az olamaz");

                _ad = value;
            }
            get //return
            {
                return _ad.Substring(0, 1).ToUpper() + _ad.Substring(1).ToLower();
            }
        }

        public string Soyad //PascalCase kullanımı yapılması önerilir.
        {
            // Propertyler fieldler içerisindeki değerleri okuma ve yazma işlemi için kullanılır.
            get
            {
                return _soyad.Substring(0, 1).ToUpper() + _soyad.Substring(1).ToLower();
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new FormatException("Kişinin soyadı boz geçilemez");
                }

                foreach (char harf in value)
                {
                    if (char.IsDigit(harf))
                        throw new Exception("Kişinin soyadında rakam bulunamaz");
                    if (char.IsSymbol(harf) || char.IsControl(harf) || char.IsPunctuation(harf))
                        throw new Exception("Kişinin soyadında geçersiz karekterler bulunmaktadır.");
                }
                if (value.Length > 50 || value.Length < 2)
                    throw new Exception("Gİrilen ifade 50 karekterden fazal olamaz");

                _soyad = value;
            }
        }
        public string TcNo
        {
            get { return _tcNo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new FormatException("Kişinin Tc No  boş geçilemez");
                if (value.Length < 11 || value.Length > 11)
                    throw new Exception("Girilen TC kimlik numarası 11 haneli olmalıdır");
                if (value.StartsWith("0"))
                    throw new Exception(" Girilen TC no 0 ile başlayamaz");
                if (value.EndsWith('1') || value.EndsWith('3') || value.EndsWith('5') || value.EndsWith('7') || value.EndsWith('9'))
                    throw new Exception("Girilen TC No sonu çift sayı ile bitmeli");
                foreach (char sayi in value)
                    if (char.IsLetter(sayi))
                        throw new Exception("Kişinin TC no da harf bulunamaz");
                _tcNo = value;

                //------------------Farklı bir konrtol yolu ---------------
            }

        }//Full Property

        public DateTime DogumTarihi{ get; set; } // Auyo property --> ile otomatik kendiliğinden okuma yazma yapan property bunun için ayrıyeten field tanımlanmasına gerek kalmaz.

        public int Yas 
        {
            get
            {
                return DateTime.Now.Year - this.DogumTarihi.Year;
            }
        }


        public DateTime OlusturulmaZamanı { get; private set; } //Dışardan setlenemez içerden setlenir.

        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad} - {this.Yas}";
                
        }
    }

}


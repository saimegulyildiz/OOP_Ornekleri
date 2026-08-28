using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinifolusturmaornek
{
    internal class ogrenciler
    {
        private string ogrno;
        private string ad;
        private string soyad;
        private string sinif;
        public string Sinif
        {
            get
            {
                return sinif;
            }
            set
            {
                sinif = value;
            }
        }
        public string Ogrno
        {
            get
            {
                return ogrno;
            }
        }
        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }
        public string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }
        public void bilgiler()
        {
            Console.WriteLine(" ogrno gir");
             ogrno = Console.ReadLine();
            if (ogrno.Length != 10)
            {
                ogrno = "2211012001";
                sinif = "kaldi";

            }
            else
            {
                if (ogrno.Substring(0, 2) == "22")
                {
                    sinif = "2";
                }

            }
            Console.WriteLine("{0} adi   {1}  soyadi    {2}   ogrno   {3}  sinif       ", ad, soyad, ogrno, sinif);

        }
    }
}

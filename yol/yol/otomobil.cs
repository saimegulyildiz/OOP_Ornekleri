using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yol
{
    internal class otomobil
    {
        public string marka;
        private int yas;
        public string model;
         public void gazabas()
        {
            Console.WriteLine("gaza basildi");
        }
        public int arabaninyasi
        {
            get
            {
                return yas;
            }
            set
            {
                if (value <= 10)
                {
                    yas = 0;
                }
                yas = value;
              
            }
        }


    }
}

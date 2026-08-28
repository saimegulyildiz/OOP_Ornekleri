using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yol
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            otomobil o = new otomobil();
            o.marka = "ford";
            o.model = "fiesta";
            Console.WriteLine(o.marka);
            o.gazabas();
            bisiklet b = new bisiklet();
            b.marka = "h";
            b.lastikdegistir();
            o.arabaninyasi = 15;
            Console.WriteLine(o.arabaninyasi);


        }
    }
}

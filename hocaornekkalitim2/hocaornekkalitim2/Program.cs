using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hocaornekkalitim2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            laptop la = new laptop();
            la.ram = "8";
            la.serino = "19191919";
            la.pilomru = 2;
            la.marka = "acer";
            la.islemci = "amd";
            la.bloototh = "var";
            la.bilgisayarbilgisi();
            la.cihazbilgisi();
            la.laptopbilgisi();
            //kurucu metodlar otomatik olarak çalışır ve kalıtımda en üst sınıftan hiyerarşik olarakr çalışır
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hocaornekkalitim2
{
    internal class laptop:bilgisayar
    {
        public string bloototh;
        public int pilomru;
        public void laptopbilgisi()
        {
            Console.WriteLine("{0} blootoh    {1} pilomru",bloototh,pilomru);
        }
    }
}

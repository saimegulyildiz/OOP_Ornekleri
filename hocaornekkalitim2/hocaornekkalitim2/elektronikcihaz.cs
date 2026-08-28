using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hocaornekkalitim2
{
    internal class elektronikcihaz
    {
        public string marka;
        public string serino;
        public void cihazbilgisi()
        {
            Console.WriteLine("{0} marka    {1}  serino",marka,serino);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hocaornekkalitim2
{
    internal class bilgisayar:elektronikcihaz
    {
        public string islemci;
        public string ram;
        public void bilgisayarbilgisi()
        {
            Console.WriteLine("{0} islemci    {1}  ram",islemci,ram);
        }
    }
}

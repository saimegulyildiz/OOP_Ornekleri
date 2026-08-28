using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcaseornek
{
    internal class Program
    {
//        Trafik lambasının renklerine göre ne yapmamız gerektiğini söyleyen console
// uygulaması
// (Sarı koşuluna girdiğinde bir önceki ışığın ne olduğunu sorsun ve eğer kırmızıysa
//yeşil case ine eğer yeşil ise kırmızı case ine gitsin
        static void Main(string[] args)
        {
            string renk = Console.ReadLine();
            switch (renk)
            {
                case "kirmizi":
                    Console.WriteLine("dur");
                    break;
                case "sari":
                    Console.WriteLine("önceki hangi renkti");
                    string renk2 = Console.ReadLine();

                    if (renk2 == "yesil")
                    {
                        goto case "kirmizi";

                    }
                    else
                    {
                        goto case "yesil";
                    }
                    break;
                case "yesil":
                    Console.WriteLine("gec");
                    break;
                default:
                    break;
            }  


        }
    }
}

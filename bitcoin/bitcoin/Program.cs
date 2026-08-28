using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitcoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tecrubenizi girin 1 2");
            int tecrube = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hesap parasi girin");
            int hesap = Convert.ToInt32(Console.ReadLine());

            switch (tecrube)
            {
                case 1:
                    if (hesap <= 1000)
                    {
                        Console.WriteLine("hepsini cekebilirsin");
                    }
                    else
                    {
                        Console.WriteLine((hesap * (0.4))+ "CEKEBİLİRSİN");


                    }
                    break;
                case 2:


                    if (hesap <= 5000)
                    {
                        Console.WriteLine("hepsini cekebilirsin");
                    }
                    else
                    {
                        Console.WriteLine((hesap * (0.6)) + "CEKEBİLİRSİN");


                    }
                    break;

            }
        }
    }
}

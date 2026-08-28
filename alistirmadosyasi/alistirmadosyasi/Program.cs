using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace alistirmadosyasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string isim = "gul";
            //int a = 10;
            //int b = 20;
            //int toplam;
            //toplam = a + b;
            //Console.WriteLine(toplam);
            //Console.WriteLine(isim);
            //string isim = Console.ReadLine();
            //string soyisim = Console.ReadLine();
            //Console.WriteLine("hosgeldiniz");
            //Console.WriteLine("notlari gir");

            //double not1 = Convert.ToDouble(Console.ReadLine());

            //double not2 = Convert.ToDouble(Console.ReadLine());
            //double ort = (not1 + not2) / 2;

            //Console.WriteLine("{0}          {1}      {2}",isim,soyisim,ort);
            //klavyeden girilen sasyının hangisinin büyük küçük olduğunu bulma
            //            Console.WriteLine("2 sayi gir");
            //            int sayi1 = Convert.ToInt32(Console.ReadLine());
            //            int sayi2 = Convert.ToInt32(Console.ReadLine());
            //            if (sayi1 > sayi2)
            //            {
            //                Console.WriteLine("{0} buyuktur {1}",sayi1,sayi2);


            //            }
            //            else
            //            {
            //                Console.WriteLine("{1} buyuktur {0}", sayi1, sayi2);

            //            }
            //            Kullanıcıdan kare veya dikdörtgen ifadelerinden birinin seçimi istenilecektir. Seçime göre Alan
            //veya Çevre hesaplarından hangisinin yapılması gerektiği istenilecektir. Seçime göre kenar
            //uzunlukları istenilecek ve işlemler gerçekleştirilecektir
            //        int sonuc=0;
            //        Console.WriteLine("kare mi dikdortgen mi");
            //        string sekil = Console.ReadLine();
            //        if (sekil == "dikdortgen")
            //        {
            //            Console.WriteLine("cevre mi alan mi");
            //            string islem = Console.ReadLine();
            //            if (islem == "cevre")
            //            {
            //                Console.WriteLine(" kenarlari gir");
            //                int kenar1 = Convert.ToInt32(Console.ReadLine());
            //                int kenar2 = Convert.ToInt32(Console.ReadLine());

            //                sonuc = (kenar1 + kenar2) * 2;
            //            }
            //            else if (islem == "alan")
            //            {
            //                Console.WriteLine(" kenarlari gir");
            //                int kenar1 = Convert.ToInt32(Console.ReadLine());
            //                int kenar2 = Convert.ToInt32(Console.ReadLine());
            //                sonuc = kenar1 * kenar2;

            //            }
            //        }
            //        if (sekil == "kare") { 
            //        Console.WriteLine("cevre mi alan mi");
            //        string islem = Console.ReadLine();
            //        if (islem == "cevre")
            //        {
            //            Console.WriteLine(" kenarlari gir");
            //            int kenar1 = Convert.ToInt32(Console.ReadLine());


            //            sonuc = (kenar1 + kenar1) * 2;
            //        }
            //        else if (islem == "alan")
            //        {

            //            Console.WriteLine(" kenari gir");
            //            int kenar1 = Convert.ToInt32(Console.ReadLine());

            //            sonuc = kenar1 * kenar1;
            //        }
            //    }
            //        Console.WriteLine(sonuc);
            //ayları switch case ile yaz
            //    Console.WriteLine("kacinci ayda oldugunu soyle");
            //    int ay = Convert.ToInt32(Console.ReadLine());
            //    switch (ay)
            //    {
            //        case 1:
            //            Console.WriteLine("ocak");
            //            break;
            //    }
            //**************************************DONGULER********************************************
            // for(int i = 1; i <= 100; i++)
            //     {
            //         Console.WriteLine(i);
            //     }
            //ekrana isparta yaz 10 kere while
            //            int sayac = 0;
            //            while (sayac < 10)
            //            {
            //                Console.WriteLine("isparta");
            //                sayac++;
            //            }
            //            Örneğin şifreli bir sitemde giriş yapılmaya çalışılsın.3 kez yanlış girildiği
            //durumda dışarı atılsın.
            //int sifre = 123;
            //int sayac = 0;

            //do
            //{
            //    int deneme = Convert.ToInt32(Console.ReadLine());
            //    if (deneme != sifre){
            //        sayac++;
            //        Console.WriteLine("yanlis");

            //    }
            //    else
            //    {
            //        Console.WriteLine("dogru");
            //        break;
            //    }
            //} while (sayac < 3);
            //             Klavyeden sayılar girilmesi istenecek ve yalnızca girilen çift sayılar toplanacak tek sayı girdiğinde toplama işlemi
            //            bitirilip toplam değerini ekrana yazdıran programı yapınız do while
            //            int sayi = 0;
            //            int toplam = 0;
            //            do
            //            {
            //                toplam = toplam + sayi;

            //                sayi = Convert.ToInt32(Console.ReadLine());

            //            } while (sayi % 2 == 0);
            //            Console.WriteLine(toplam);
            //            Toplam tahmin sayısı 5 olan ,1 ile 100 arasında tutulan rastgele sayıyı bulma oyunu
            //yapalım.
            // 5.hakta bilemezse «oyunu kaybettiniz» yazsın ve tutulan sayıyı ekrana yazdırsın.
            // Eğer tahmin doğruysa «tebrik ederiz 3.tahmininizde buldunuz» yazsın
            int sayac = 1;
            Random rastgele = new Random();
            int sayi = 0;
            int tutulan =rastgele.Next(0,3);

            do
            {

                Console.WriteLine("tahmin  girin");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayac == 5)
                {
                    Console.WriteLine("kaybettiniz");
                    break;
                }
                else if(tutulan==sayi)
                {
                    Console.WriteLine("dogru {0}",tutulan);
                 
                }
                    sayac++;


            } while (sayi!=tutulan);

        }
    }
}

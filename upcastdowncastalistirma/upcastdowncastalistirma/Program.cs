using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upcastdowncastalistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asker ve tanklar olacak dilediğimiz kadar girilebilen
            //savaşa katılan asker ve tankların isimleri ve hangi cepheden katıldıgı bilgileri listelenecek
            //buna ek olarak asker ve tanklatrın kenddine özel özellikleri katıldıkları cepheye göre belirlenecek
            //bu bilgilerin hepsi ekrana yazdırılacak
            // son olarak verilen bilgilerle savaş tutarı hesaplanarak savaşın ne kadara mal olduğu hesaplanacak 
            //savaş maliyeti ve cepheye göre özellik bilgileri
            //asker batıdan geliyorsa sürünüyor askerin maliyeti 1000 tl sürün fonksiyonu ile sürünüyor bilgisi verilecek
            //asker doğudan geliyorsa koşuyor askerin maliyeti 2000 tl koş fonksiyonu ile koşuyor bilgisi verilecek
            //tank batıdan geliyorsa sinyal gönderiyor her tank 10000 tl sinyalgönder fonksiyonu ile sinyal gönderiyor bilgisi verilecek
            //tank batıdan geliyorsa top atıyor her tank 20000 tl topat fonksiyonu ile top atıyor bilgisi verilecek
            //birlik üst sınıfında asker ve tankların ortak özellikleri tanımlanacak
            //ana fonksiyonda oluşturulan listeye upcast ile minimum 5 asker bilgisi eklenecek
            //en son olarakta her bir savaşa katılanın ismi ve cephe bilgisi ile asker ya da tank olmasına göre down cast işlemi ile downcast uygulanıp
            //maliyet bilgisi ekrana yazdırılacak.
            List<birlik> savasakatilanlar = new List<birlik>();
            savasakatilanlar.Add(new asker { isim = "h", cephe = "bati" });
            savasakatilanlar.Add(new asker { isim = "p", cephe = "dogu" });
            savasakatilanlar.Add(new tank { isim = "k", cephe = "bati" });
            savasakatilanlar.Add(new tank { isim = "r", cephe = "dogu" });
            int maliyet = 0;
foreach(birlik b in savasakatilanlar)
            {
                Console.WriteLine("{0}      {1}", b.cephe, b.isim);
                if(b is asker)
                {
                    if (b.cephe == "bati")
                    {
                        asker aa = (asker)b;
                        aa.sürün();
                        maliyet = maliyet + 1000;

                    }else if (b.cephe == "dogu")
                    {
                        asker aa = (asker)b;
                        aa.kos();
                        maliyet += 2000;
                    }
                    
                }else if(b is tank)
                {
                    if (b.cephe == "bati")
                    {
                        tank tt = (tank)b;
                        tt.sinyalgonder();
                        maliyet += 10000;

                    }else if (b.cephe == "dogu")
                    {
                        tank tt = (tank)b;
                        tt.topat();
                        maliyet += 20000;

                    }
                }
            }
            Console.WriteLine(maliyet);
        }
    }
}

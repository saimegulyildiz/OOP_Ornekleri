using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace sinifolusturmaornek
{
//    Ogrenci isimli bir sinifta ogrencinin
//Ogrno, Ad, Soyad, Sinif
// Bilgileri tutulacak.Butun bilgilerin disaridan dogrudan erisimi kapali olacak (Private). 
//Ogrno bilgisi 10 haneli girilmezse sistem otomatik olarak ogrno bilgisini “2211012001” olarak
//tanimlayacak. girilen ogr bilgisinin ilk 2 sayisina gore ogrencinin kacinci sinif oldugu bilgisini
//sistem otomatik olarak bulacak.
// Sistemde main fonksiyonunda ogrencinin ogrno ad soyad bilgileri girildikten sonra ekrana
//ogrencinin ogrno, ad , soyad, sinif bilgileri ogrenci sinifinin altinda olusturulan bir metot
//kullanilarak alt alta ekrana yazdirilacak.
    internal class Program
    {
        static void Main(string[] args)
        {

            ogrenciler bilgi = new ogrenciler();
            Console.WriteLine(" isim gir");

            bilgi.Ad = Console.ReadLine();
            Console.WriteLine(" soyisim gir");

            bilgi.Soyad = Console.ReadLine();
            bilgi.bilgiler();

        }
    }
}

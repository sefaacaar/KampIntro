using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Biravo...Sepete Eklendi!!" + urun.Adi);
        }
        
        //hatalı kullanım because yazabilirsin ama yazma çünküüğ bir tane özellik eklesen tüm sayfalarda değiştirmen lazım çünkü tüm sayfalarına yeni parametre geldi geçmiş olsun..
        public void Ekle2(string urunAdi, string aciklama, double fiyat) //burada ekleyince tek tek tüm fonksiyonların parametresini düzeltmen gerekiyor o yüzden class
        {
            Console.WriteLine("Biravo...Sepete Eklendi : " + urunAdi);
        }
    }
}

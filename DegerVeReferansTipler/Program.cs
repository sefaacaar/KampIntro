using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65; */
            //sayi1 ?? 30
            /*
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999; */
            //sayilar1[0] ?? 999

            //int,decimal,floatdouble,bool = değer tip   değerini ona atıyor sonradan değiştirmen etkilemiyor.. değeri atıyosun değiştiriyosun
            //array,class,interface = referans tip  adını değiştiriyosun sayilar 1 gidiyor sayilar 2 oluyor..adresi atıyosun değiştiriyosun adres değişince eski adresi sayilar1 silinecek bellekten.

            /* 
             stack --> değer tip  sadece değeri aktarır ,eşitler, kopyalar...                       
             heap  --> referans tip 
             intle sayılar1 denildiğinde stacke attı new deyince heapde tuttu değerleri
             */
            Console.ReadLine();
        }
    }
}

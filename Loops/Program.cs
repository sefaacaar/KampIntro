using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Python";
            string kurs3 = "Java";
            string kurs4 = "C++";
            string kurs5 = "Flutter";

            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Python", "Java", "C++", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            //dizi temelli yapıları tek tek döner,dizilere uygulanır : foreach
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);//eleman için kullandığı isim kurs 
            }

            Console.WriteLine("sayfa sonu - footer");
            Console.ReadLine();
        }
    }
}

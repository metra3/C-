/*
İlk olarak ekranda
1-Kare
2-Dikdörtgen
gibi iki seçenek görünür. Kullanıcı hangi seçeneği seçerse seçilen seçeneğe göre
1-Alan
2-Çevre
seçenekleri ekrana gelir. Hangi seçimi yaparsa onunla ilgili bilgi alma ekranı gelir ve sonuç
görüntülenir.
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim1;
            int secim2;
            int a;
            int b;
            int alan;
            int cevre;

            Console.WriteLine("1-Kare\n2-Dikdörtgen");
            Console.Write("Sekil Secimini Yapiniz:");
            secim1 = Convert.ToInt32(Console.ReadLine());

            if (secim1 == 1)
            {
                Console.WriteLine("1-Alan\n2-Çevre");
                Console.WriteLine("Hesabini yaptirmak istedigin islemi sec:");
                secim2 = Convert.ToInt32(Console.ReadLine());

                if (secim2 == 1)
                {
                    Console.Write("Kenar Uzunlugunu giriniz:");
                    a = Convert.ToInt32(Console.ReadLine());
                    alan = a * a;
                    Console.WriteLine("Karenin Alani:{0}", alan);
                    Console.ReadLine();
                }

                else if (secim2 == 2)
                {
                    Console.Write("Kenar Uzunlugunu giriniz:");
                    a = Convert.ToInt32(Console.ReadLine());
                    cevre = 4 * a;
                    Console.WriteLine("Karenin Cevresi:{0}", cevre);
                    Console.ReadLine();
                }
            }

            else if (secim1 == 2)
            {
                Console.WriteLine("1-Alan\n2-Çevre");
                Console.WriteLine("Hesabini yaptirmak istedigin islemi sec:");
                secim2 = Convert.ToInt32(Console.ReadLine());

                if (secim2 == 1)
                {
                    Console.Write("Kisa Kenar Uzunlugunu giriniz:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Uzun Kenar Uzunlugunu giriniz:");
                    b = Convert.ToInt32(Console.ReadLine());
                    alan = a * b;
                    Console.WriteLine("Dikdortgenin Alan:{0}", alan);
                    Console.ReadLine();
                }

                else if (secim2 == 2)
                {
                    Console.Write("Kisa Kenar Uzunlugunu giriniz:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Uzun Kenar Uzunlugunu giriniz:");
                    b = Convert.ToInt32(Console.ReadLine());
                    cevre = (2 * a) + (2 * b);
                    Console.WriteLine("Dikdortgenin Cevresi:{0}", cevre);
                    Console.ReadLine();
                }
            }
        }
    }
}


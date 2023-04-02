/*
▪ Kullanıcıdan alınan 2 sayıya yine kullanıcıdan alınacak değere göre dört işlem uygulayan
C# programını yazınız. (Toplama için 1, Çıkartma için 2, Çarpma için 3, Bölme için 4
girilecek. Bu değerler dışındaki girişler için hatalı giriş yaptınız şeklinde uyarı verecek.)
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
            int sayi1, sayi2;
            byte secim;
            double sonuc;

            Console.Write("Sayi1'i giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sayi2'yi giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1-Toplama\n2-Cikarma\n3-Carpma\n4-Bolme");
            Console.Write("Yapmak istediginiz islemi seciniz:");
            secim = Convert.ToByte(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    sonuc = Convert.ToDouble(sayi1 + sayi2);
                    Console.WriteLine("Sonuc: {0}", sonuc);
                    Console.ReadLine();
                    break;

                case 2:
                    sonuc = Convert.ToDouble(sayi1 - sayi2);
                    Console.WriteLine("Sonuc: {0}", sonuc);
                    Console.ReadLine();
                    break;

                case 3:
                    sonuc = Convert.ToDouble(sayi1 * sayi2);
                    Console.WriteLine("Sonuc: {0}", sonuc);
                    Console.ReadLine();
                    break;

                case 4:
                    sonuc = Convert.ToDouble(sayi1 / sayi2);
                    Console.WriteLine("Sonuc: {0}", sonuc);
                    Console.ReadLine();
                    break;
            }

            }
    }
}

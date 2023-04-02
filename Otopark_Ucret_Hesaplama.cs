/*
Bir otoparkın ücret tarifesi şöyledir:
0 – 3 saat: 4 TL
3 – 7 saat: 3 TL
7 – 12 saat: 2 TL
12 ve üzeri: 1 TL’dir.
Buna göre girilen saate göre otoparka ödenecek ücreti hesaplayıp ekrana yazan programı
oluşturunuz.
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
            int saat;
            double ucret;
            double tutar;

            Console.Write("Otoparkta Kac saat bulundunuz:");
            saat = Convert.ToInt32(Console.ReadLine());

            if (0<saat && saat<=3)
            {
                ucret = 4;
                tutar = saat * ucret;
                Console.WriteLine("Odenecek Tutar: {0}",tutar);
                Console.ReadLine();
            }

            else if (3 < saat && saat <= 7)
            {
                ucret = 3;
                tutar = saat * ucret;
                Console.WriteLine("Odenecek Tutar: {0}", tutar);
                Console.ReadLine();
            }

            else if (7 < saat && saat <= 12)
            {
                ucret = 2;
                tutar = saat * ucret;
                Console.WriteLine("Odenecek Tutar: {0}", tutar);
                Console.ReadLine();
            }
            
            else if (saat > 12)
            {
                ucret = 1;
                tutar = saat * ucret;
                Console.WriteLine("Odenecek Tutar: {0}", tutar);
                Console.ReadLine();
            }
        }
    }
}

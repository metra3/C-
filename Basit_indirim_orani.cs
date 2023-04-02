/*
Bir mağaza müşterilerine yaptıkları alışveriş tutarına göre indirim yapmaktadır.
200 TL ye kadar olan alışverişler için %10
200-400 TL arası olan alışverişler için %15
400 TL den fazla olan alışverişler için %20 Buna göre bir kişinin ödeyeceği net miktarı
hesaplayan C# programın kodunu yazınız
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
            int tutar;
            double indirim;
            double odeme_miktari;
            Console.Write("Alisveris Tutari: ");
            tutar = Convert.ToInt32(Console.ReadLine());

            if(tutar<200)
            {
                indirim = (tutar*0.1);
                odeme_miktari = tutar - indirim;
            }

            else if(tutar>=200 && tutar<=400)
            {
                indirim = (tutar*0.15);
                odeme_miktari = tutar - indirim;
            }
            
            else
            {
                indirim = (tutar*0.2);
                odeme_miktari = tutar - indirim;
            }

            Console.Write("Odenecek Tutar = {0}",odeme_miktari);
            Console.ReadLine();
        }
    }
}

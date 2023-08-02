using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen birinci sayiyi girin : ");
            int sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayiyi giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Topla(sayi1, sayi2);
            Fark(sayi1, sayi2);
            Carp(sayi1,sayi2);
            Bol(sayi1,sayi2);

            Console.Read();
        }

        static void Topla(int sayi1,int sayi2)
        {
            int sum = sayi1 + sayi2;
            Console.WriteLine("İki sayının toplamı : " + sum);
        }
        static void Fark(int sayi1,int sayi2)
        {
            int fark = sayi1 - sayi2;
            Console.WriteLine("İki sayinin farki : " + fark );
        }
        static void Carp(int sayi1,int sayi2)
        {

            int carp = sayi1 * sayi2;
            Console.WriteLine("İki sayinin carpimi : " + carp);
        }
        static void Bol(int sayi1,int sayi2)
        {
            int bol = sayi1 / sayi2;
            Console.WriteLine("İki sayinin bolumu : " + bol);
        }
    }
}

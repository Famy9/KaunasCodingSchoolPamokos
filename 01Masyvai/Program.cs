

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Masyvai
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pazymiai = { 7, 8, 2, 6, 9, 1, 5, 5, 4 };

            var masynos = new string[4];

            masynos[0] = "audi";
            masynos[1] = "BMW";
            masynos[2] = "Fiat";
            masynos[3] = "Lada";


            string[] cars = { "labas", "Kaip", "Gyveni", "Gerai"};


            Console.WriteLine("Masyvu dydis");
            Console.WriteLine("Masynos: " + masynos.Length);
            Console.WriteLine("Pazymiai: " + pazymiai.Length);

            Console.WriteLine("Pazymiu masyvo prima reiksme: " + pazymiai.First());
            Console.WriteLine("Pazymiu masyvo paskutine reiksme: " + pazymiai.Last());




            Console.ReadKey();
        }
    }
}

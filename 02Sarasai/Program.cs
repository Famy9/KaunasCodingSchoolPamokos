using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Sarasai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kiek pazymiu norite ivesti? " );
            var a = Convert.ToInt32(Console.ReadLine());
            var rnd = new Random();
            List<int> pazymiai = new List<int>(a);

            for (int i = 0; i < a; i++)
            {
                Console.Write("iveskite pazymi: ");

                var g = Convert.ToInt32(Console.ReadLine());

                pazymiai.Add(g);


            }
            foreach (var sk in pazymiai)
            {
                Console.WriteLine(sk);
            }

            Console.WriteLine("didziausias pazimys: " + pazymiai.Max());
            Console.WriteLine("maziausias pazimys: " + pazymiai.Min());
            Console.WriteLine("pazymiu vidurkis:  " + pazymiai.Average());

         

            Console.WriteLine("atsitiktinis skaicius: " + pazymiai[rnd.Next(pazymiai.Count)]);



            Console.ReadKey();

        }
    }
}

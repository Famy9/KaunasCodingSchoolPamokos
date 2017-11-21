using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Papildoma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite Staciakampiu: ");

            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            var Plotas = a * b;
            var Perimetras = (a + b) * 2;

            Console.WriteLine("Staciakampio plotas: " + Plotas );
            Console.WriteLine("Staciakampio perimetras: " + Perimetras);


            Console.WriteLine("Iveskite trikampio krastines: ");

            var d = Convert.ToInt32(Console.ReadLine());
            var e = Convert.ToInt32(Console.ReadLine());
            var f = Convert.ToInt32(Console.ReadLine());

            var TPlotas = (d * e) / 2;
            var TPerimetras = d + e + f;

            Console.WriteLine("Trikampio Plotas: "+ TPlotas);
            Console.WriteLine("Trikampio Perimetras: "+ TPerimetras);


            Console.ReadKey();

        }

        public int Plotas(int a, int b)
        {
            return a * b;
        }
        public int Perimetras(int a, int b)
        {
            return (a + b) * 2;

        }
        public int TPlotas (int a , int  b)
        {
            return (a * b) / 2;
        }
        public int TPerimetras(int a, int b, int c)
        {
            return a + b + c;
        }

    }
}

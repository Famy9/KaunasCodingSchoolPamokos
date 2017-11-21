using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite 2 skaicius: ");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());

            var programa = new Program();

            var sumosats = programa.Suma(pirmas, antras);
            Console.WriteLine(sumosats);

            var skirtumoAts = programa.Skirtumas(pirmas, antras);
            Console.WriteLine(skirtumoAts);

            var sandaugosAts = programa.Sandauga(pirmas, antras);
            Console.WriteLine(sandaugosAts);

            var dalybosAts = programa.Dalyba(pirmas, antras);
            Console.WriteLine(dalybosAts);

            Console.WriteLine(programa.Suma(pirmas, antras));

           

            var suma = programa.Suma(pirmas, antras);
            var skritumas = programa.Skirtumas(pirmas, antras);
            var  sandauga = programa.Sandauga(pirmas, antras);
            var dalmuo = programa.Dalyba(pirmas, antras);

            Console.WriteLine("{0} + {1} = {2}", pirmas, antras, suma);
            Console.WriteLine("{0} - {1} = {2}", pirmas, antras, skritumas);
            Console.WriteLine("[0} * {1} = {2}", pirmas, antras, sandauga);
            Console.WriteLine("{0} / {1} = {2}", pirmas, antras, dalmuo);

            Console.ReadKey();
        }

        public int Suma(int a, int b )
        {
            return a + b;

        }
        public int Skirtumas(int a, int b)
        {
            return a - b;
        }
        public int Sandauga(int a, int b)
        {
            return a * b;
        }
        public double Dalyba(int a, int b)
        {
            return  (double)a / b;
        }


    }
}

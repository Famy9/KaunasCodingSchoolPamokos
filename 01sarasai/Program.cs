using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01sarasai
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skaiciai = new List<int>();
            var rnd = new Random();
            var keikSugeneruoti = rnd.Next(1, 11);

            for (int i = 0; i < keikSugeneruoti; i++)
            {
                skaiciai.Add(rnd.Next(1, 11));

                Console.WriteLine(skaiciai[i]);
            }

            var labas = skaiciai.Average();
            int suma = 0;
            foreach (var vidurkis in skaiciai)
            {
                if (labas < vidurkis)
                {
                    suma++;
                }
            }

            int suma1 = 0;
            foreach (var suma_1 in skaiciai)
            {
                if (suma_1% 2 == 0)
                {
                    suma1 += suma_1;
                }
            }

            Console.WriteLine("maziausias skaicus: " + skaiciai.Min());
            Console.WriteLine("didziausias skaicus: " + skaiciai.Max());
            Console.WriteLine("vidurkis: " + skaiciai.Average());
            Console.WriteLine("uz vidurki maziau: " + suma);
            Console.WriteLine("lyginiu skaiciu suma: " + suma1);


            Console.ReadKey();
        }
    }
}

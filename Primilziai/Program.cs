using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primilziai
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> primilziai = new List<double>();
            var programa = new Program();
            programa.Ivedimas(primilziai);
            programa.Isvedimas(primilziai);

            Console.WriteLine("Maziausias: " + programa.Maziausias(primilziai));
            Console.WriteLine("Didziausias: " + programa.Didziausias(primilziai));
            Console.WriteLine("Vidutinis: " + programa.Vidutinis(primilziai));

            Console.ReadKey();

        }

        public void Ivedimas(List<double> primilziai)
        {
            Console.WriteLine("Iveskite primilziu kieiki: ");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.Write("iveskit: ");
                primilziai.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }

        public void Isvedimas(List<double> primilziai)
        {
            foreach (var isv in primilziai)
            {
                Console.WriteLine(isv + " l ");
            }
        }

        public double Maziausias(List<double> primilziai)
        {
            return primilziai.Min();
        }
        public double Didziausias(List<double> primilziai)
        {
            return primilziai.Max();
        }
        public double Vidutinis(List<double> primilziai)
        {
            return primilziai.Average();
        }
        public int DUPRimilziai(List<double> primilziai)
        {
            var a = 0;
            var b = 0;
            foreach (var lab in primilziai)
            {
                if ()
                {

                }
            }
        }

    }
}

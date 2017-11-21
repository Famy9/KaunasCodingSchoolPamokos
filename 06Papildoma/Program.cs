using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Papildoma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> atlyginimas = new List<double>();
            List<double> Daugiau = new List<double>();

            var programa = new Program();

            programa.Ivedidmas(atlyginimas);

            Console.WriteLine("maziausia alga " + programa.MaziausiaAlga(atlyginimas));

            Console.WriteLine("Didziausia alga " + programa.DidziausiaAlga(atlyginimas));
        
            Console.WriteLine("algu vidurkis  " + programa.AlguVidurkis(atlyginimas));

            Console.WriteLine("daugiau uz vidurki  " + programa.DaugiauUzVidurki(atlyginimas));

            var dau = programa.DaugiauUzVidurki(atlyginimas);

            Console.WriteLine("daugiau uz 1500$ " + programa.DaugiauUz1500(atlyginimas));



            Console.ReadKey();
        }

        public void Ivedidmas(List<double> atlyginimas)
        {
            Console.WriteLine("Kiek atlyginimu gavote? ");
            var a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Iveskite " + (i + 1) +" atlyginima");
                var b = Convert.ToInt32(Console.ReadLine());
                atlyginimas.Add(b);
            }

            foreach (var atlyg in atlyginimas)
            {
                Console.WriteLine(atlyg + "$ ");
            }

            
        }

        public double MaziausiaAlga(List<double> atlyginimas)
        {
            return atlyginimas.Min();
        }
        public double DidziausiaAlga(List<double> atlyginimas)
        {
            return atlyginimas.Max();
        }
        public double AlguVidurkis(List<double> atlyginimas)
        {
            return atlyginimas.Average();
        }
        public double DaugiauUzVidurki(List<double> atlyginimas)
        {
            var labas = atlyginimas.Average();
            int suma = 0;
            foreach (var vidurkis in atlyginimas)
            {
                if (labas < vidurkis)
                {
                    suma++;
                }
            }
            return suma;
        }
        public double DaugiauUz1500(List<double> atlyginimas)
        {
            int suma = 0;
            foreach (var vidurkis in atlyginimas)
            {
                if (vidurkis >= 1500)
                {
                    suma++;
                }
            }
            return suma;

        }
        public double trysDidziausios(List<double> atlyginimas)
        {
           
        }

    }
}

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Masinos
{
    class Program
    {
        static void Main(string[] args)
        {
            var auto = new automobilis("audine", "A6", 1958, 4, 600, 9000);
            auto.Isvedimas();

            var automobiliai = new List<automobilis>
            {
                new automobilis("BMW", "X6", 1000, 5, 500, 1000),
                new automobilis("Lada", "CUper", 1960, 2, 30, 3000000 ),
                new automobilis("Mercedez_Benz", "S Class", 2004, 3, 400, 564456000),
                new automobilis("Toyota", "Corola", 2006, 1, 320, 1000654),
                new automobilis("Citroen", "C5", 1930, 2.2, 150, 321000),
            };

            var programa = new Program();
            programa.Isvedimas(automobiliai);

            var Naujausias = programa.NaujasAuto(automobiliai);
            Console.WriteLine("Naujausias Auto: " );
            Naujausias.Isvedimas();

            var Seniausias = programa.SenasMetai(automobiliai);
            Console.WriteLine("Seniausias Automobilis: " );
            Seniausias.Isvedimas();

            var Galia = programa.DidziausiaGalia(automobiliai);
            Console.WriteLine("Didziausios Galios Automobilis: ");
            Galia.Isvedimas();

            var Nuvaziavo = programa.NuvaziavoKM(automobiliai);
            Console.WriteLine("Maziausiai Nuvaziaves Automobilis: ");
            Nuvaziavo.Isvedimas();


        }
        public void Isvedimas(List<automobilis> automobiliai)
        {
            foreach (var auto in automobiliai)

            {
                auto.Isvedimas();
            }
        }
        public automobilis NaujasAuto(List<automobilis> automobiliai)
        {
            var AUTOMob = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (auto.Metai > AUTOMob.Metai)
                {
                    AUTOMob = auto;
                }

            }

            return AUTOMob;
        }
        public automobilis SenasMetai(List<automobilis> automobiliai)
        {
            var Autometai = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (Autometai.Metai  > auto.Metai)
                {
                    Autometai = auto;
                }
            }
            return Autometai;
        }
        public automobilis DidziausiaGalia(List<automobilis> automobiliai)
        {
            var Galia = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (Galia.Galia < auto.Galia)
                {
                    Galia = auto;
                }
            }
            return Galia;
        }
        public automobilis NuvaziavoKM(List<automobilis> automobiliai)
        {
            var Nuvaziavo = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (Nuvaziavo.Rida > auto.Rida)
                {
                    Nuvaziavo = auto;
                }
            }
            return Nuvaziavo;
        }



    }
}

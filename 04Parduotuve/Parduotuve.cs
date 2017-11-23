using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Parduotuve
{
    class Parduotuve
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Preke> Prekes { get; private set; }

        public Parduotuve(string pavadinimas, string adresas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Prekes = new List<Preke>();

            Console.WriteLine("1. Generuoti prekes");
            Console.WriteLine("2. Suvesti prekes");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    SugeneruotiPrekes();
                    break;
                case 2:
                    SuvestiPrekes();
                    break;
                default:
                    SugeneruotiPrekes();
                    break;
            }
        }
        public Parduotuve(string pavadinimas, string adresas, List<Preke> prekes)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            
        }
        public void SugeneruotiPrekes()
        {
            var rnd = new Random();
            var kiekis = rnd.Next(1, 20);
            var sakinys = "Lorem Ipsum Dolor Sit Amet Consectetur Adipiscing Elit Maecenas Porttitor Pulvinar Nibh In Vestibulum Nisl Mollis At Aliquam Tempus Mi";
            var zodziai = sakinys.Split(' ');
           /* var zodziai = new []
            {
                zodis1 = 
            }*/

            for (int i = 0; i < kiekis; i++)
            {
                var pavadinimas = zodziai[rnd.Next(zodziai.Length)];
                var kodas = rnd.Next(1000, 9999999).ToString();
                var kaina = rnd.Next(50, 100);
                var savikaina = rnd.Next(1, 50);
                var keikis = rnd.Next(1, 100);
                var preke = new Preke(pavadinimas, kodas, kaina, savikaina, keikis);
                Prekes.Add(preke);
            }
        }

        public void Isvedimas()
        {
            Console.WriteLine("Pavadinimas:" + Pavadinimas);
            Console.WriteLine("Adresas:" + Adresas);
            Console.WriteLine("Prekiu kiekis:" + Prekes.Count);

            Console.WriteLine();

            foreach (var Preke in Prekes)
            {
                Preke.Isvedimas();
            }

            Console.WriteLine("skaiciavimai");
            Console.WriteLine("visu prekiu kainu suma: " +  PrekiuKainuSuma());
            Console.WriteLine("visu prekiu savikainu suma: " + SavikainuSuma());
            Console.WriteLine("visu prekiu pajamos: " +  PrekiuPajamos());
            Console.WriteLine("visu prekiu pelnas: " + PrekiuPelnas());
            Console.WriteLine();
            Console.WriteLine("Pigiausia Preke");
            PrekePigiausia().Isvedimas();
            Console.WriteLine();
            Console.WriteLine("Brangiausia Preke");
            PrekeBrangiausia().Isvedimas();


        }

        public void SuvestiPrekes()
        {
            Console.WriteLine("Kiek prekiu suvesti?");
            var kiekSuvesti = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kiekSuvesti ; i++)
            {

                Console.WriteLine("{0}-OJI PREKE", i+1);
                Console.WriteLine("Pavadinimas: ");
                var pavadinimas = Console.ReadLine();
                Console.WriteLine("Kodas: ");
                var kodas = Console.ReadLine();
                Console.WriteLine("Kaina: ");
                var kaina = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("kiekis: ");
                var kiekis = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Savikaina: ");
                var savikaina = Convert.ToDouble(Console.ReadLine());
                

                var preke = new Preke(pavadinimas, kodas, kaina, savikaina,kiekis );
                Prekes.Add(preke);

            }
        }

        public double PrekiuKainuSuma()
        {
            var suma = 0.0;
            foreach (var preke in Prekes)
            {
                suma += preke.Kaina;
            }
            return suma;
        }
        public double SavikainuSuma()
        {
            var suma = 0.0;
            foreach (var preke in Prekes)
            {
                suma += preke.Savikaina;
            }
            return suma;
        }
        public double PrekiuPajamos()
        {
            var suma = 0.0;
            foreach (var preke in Prekes)
            {
                suma += preke.Kaina * preke.Kiekis;
            }
            return suma;
        }
        public double PrekiuPelnas()
        {
            var suma = 0.0;
            foreach (var preke in Prekes)
            {
                suma += (preke.Kaina - preke.Savikaina)* preke.Kiekis;
            }
            return suma;
        }
        public Preke PrekiuMaziausiai()
        {
            var suma = Prekes.First();
            foreach (var preke in Prekes)
            {
                if (preke.Kiekis < suma.Kiekis)
                {
                    suma = preke;
                }
            }
            return suma;
        }
        public Preke PrekiuDaugiausiai()
        {
            var suma = Prekes.First();
            foreach (var preke in Prekes)
            {
                if (preke.Kiekis < suma.Kiekis)
                {
                    suma = preke;
                }
            }
            return suma;
        }

        public Preke PrekePigiausia()
        {
            var suma = Prekes.First();
            foreach (var preke in Prekes)
            {
                if (preke.Kaina < suma.Kaina)
                {
                    suma = preke;
                }
            }
            return suma;
        }

        public Preke PrekeBrangiausia()
        {
            var suma = Prekes.First();
            foreach (var preke in Prekes)
            {
                if (preke.Kaina > suma.Kaina)
                {
                    suma = preke;
                }
            }
            return suma;
        }
    }
}

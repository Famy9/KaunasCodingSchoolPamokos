using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01KlasezPavyzdziai
{
    class Knyga
    {
        public int PuslapiuSkaicius;
        public string Autoriu;
        public string Pavadinimas;
        public int LeidimoMetai;

        public Knyga()
        {
            Console.WriteLine("Labas as e4su cia!");
        }

        public Knyga(string pavadinimas, string autorius, int puslapiai, int metai)
        {
            Pavadinimas = pavadinimas;
            Autoriu = autorius;
            PuslapiuSkaicius = puslapiai;
            LeidimoMetai = metai;
        }


        public void Isvedimas()
        {
            Console.WriteLine("Knyga {0} parase {1}, ja isleido " +
                "{2} metais, knyga sudaro {3} puslapiu.",
                Pavadinimas, Autoriu, LeidimoMetai, PuslapiuSkaicius);

        }
    }
}

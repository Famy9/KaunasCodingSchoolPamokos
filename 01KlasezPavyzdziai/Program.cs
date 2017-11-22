using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01KlasezPavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var knyga1 = new Knyga();
            knyga1.Pavadinimas = "Haris Floperis";
            knyga1.Autoriu = "Anonimas";
            knyga1.LeidimoMetai = 1816;
            knyga1.PuslapiuSkaicius = 12;
            knyga1.Isvedimas();

            var knyga2 = new Knyga("Voldemorto nuotykiai", "jis", 12, 1817);
            knyga2.Isvedimas();


        }
    }
}

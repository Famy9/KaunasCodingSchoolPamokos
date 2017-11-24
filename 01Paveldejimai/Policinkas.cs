using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Paveldejimai
{
    class Policinkas : Darbuotojas
    {
        public double Kysis { get; private set; }
        public double KiekSuemeNisikalteliu { get; private set; }

        public Policinkas(string vardas, string pavarde, int amzius, double alga, double etatas, double kysis, double kiekSuemeNisikalteliu)
            : base(vardas,pavarde,amzius,alga,etatas)
        {
            Kysis = kysis;
            KiekSuemeNisikalteliu = kiekSuemeNisikalteliu;
        }


        public void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Gauna Kysio: " + Kysis);
            Console.WriteLine("Kiek sugavo blogieciu: " + KiekSuemeNisikalteliu);
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Paveldejimai
{
    class Zolininkas
    {
        public int KiekTuriSeklu { get; private set; }
        public string MegstamiausiasAugalas { get; private set; }
        public int DidziausiasPasididziavimas { get; private set; }
        public int KiekTuriLaistituvu { get; private set; }

        public Zolininkas(string vardas, string pavarde, int amzius, double alga, double etatas, int kiekTuriSeklu, string megstamiausiasAugalas, int didziausiasPasididziavimas, int kiekTuriLaistituvu)
            : base(vardas, pavarde, amzius, alga, etatas)
        {
            KiekTuriSeklu = kiekTuriSeklu;
            MegstamiausiasAugalas = megstamiausiasAugalas;
            DidziausiasPasididziavimas = didziausiasPasididziavimas;
            KiekTuriLaistituvu = kiekTuriLaistituvu;
        }

        public void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Zolininkas turi {0} Seklu. ", KiekTuriSeklu);
            Console.WriteLine("Kiek sugavo blogieciu: " + KiekSuemeNisikalteliu);
            Console.WriteLine();
        }
    }
}

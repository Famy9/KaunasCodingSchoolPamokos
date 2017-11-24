using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Paveldejimai
{
    class Gaisrininkas : Darbuotojas
    {
        public int KiekTuriGesintuvu { get; private set; }
        public int KiekTuriSlangu { get; private set; }
        public int KiekLaikoDirba { get; private set; }
        public string KoksBurioPavadinimas { get; private set; }

        public Gaisrininkas(string vardas, string pavarde, int amzius, double alga, double etatas, int kiekTuriGesintuvu, int kiekTuriSlangu, int kiekLaikoDirba, string koksBurioPavadinimas)
            : base(vardas, pavarde, amzius, alga, etatas)
        {
            KiekTuriGesintuvu = kiekTuriGesintuvu;
            KiekTuriSlangu = kiekTuriSlangu;
            KiekLaikoDirba = kiekLaikoDirba;
            KoksBurioPavadinimas = koksBurioPavadinimas;
        }
        public void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Gaisrininkas turi {0} Gesintuvu: ", KiekTuriGesintuvu);
            Console.WriteLine("Gaisrininkas turi {0} Zarnu. ", KiekTuriSlangu );
            Console.WriteLine("Jis Dirba {0} Metu.", KiekLaikoDirba);
            Console.WriteLine("Jis tarnauja {0} buri.", KoksBurioPavadinimas);
            Console.WriteLine();
        }
    }
}

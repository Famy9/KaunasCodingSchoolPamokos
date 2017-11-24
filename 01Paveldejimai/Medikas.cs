using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Paveldejimai
{
    class Medikas : Darbuotojas
    {
        public int KiekTuriSvirkstu { get; private set; }
        public int KiekTuriPirstiniu { get; private set; }
        public string KoksLaipsnis { get; private set; }
        public int KiekTuriPacientu { get; private set; }

        public Medikas(string vardas, string pavarde, int amzius, double alga, double etatas, int kiekTuriSvirkstu, int kiekTuriPirstiniu, string koksLaipsnis, int kiekTuriPacientu)
            : base(vardas, pavarde, amzius, alga, etatas)
        {
            KiekTuriSvirkstu = kiekTuriSvirkstu;
            KiekTuriPirstiniu = kiekTuriPirstiniu;
            KoksLaipsnis = koksLaipsnis;
            KiekTuriPacientu = kiekTuriPacientu;
        }

        public void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Turi {0} svirkstu ", KiekTuriSvirkstu);
            Console.WriteLine("Turi {0} piristiniu  ", KiekTuriPirstiniu);
            Console.WriteLine("Daktaro Laipsnis: " + KoksLaipsnis);
            Console.WriteLine("Daktaras turi {0} Pacientu.", KiekTuriPacientu);
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Paveldejimai
{
    class Darbuotojas
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private  set; }
        public int Amzius { get; private set; }
        public double Alga { get; private set; }
        public double Etatas { get; private set; }

        public Darbuotojas(string vardas, string pavarde, int amzius, double alga, double etatas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
            Alga = alga;
            Etatas = etatas;
        }

        public void Isvedimas()
        {
            Console.WriteLine("{0} {1} ({2}) dirbdamas {3} etato uzdirba {4} euru", Vardas,Pavarde,Amzius,Etatas,Alga);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Masinos
{
    class automobiliai
    {
        public string Marke { get; private set; }
        public string Modelis { get; private set; }
        public int Metai { get; private set; }
        public int Galia { get; private set; }
        public double DarbinisTuris { get; private set; }
        public int Rida { get; private set; }

        public automobiliai(string marke, string modelis, int
            metai, double darbinisTuris, int galia, int rida)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            DarbinisTuris = darbinisTuris;
            Galia = galia;
            Rida = rida;
            
    }
        public void Isvedimas()
        {
            Console.WriteLine("Automobilis {0}  {1}, pagamintas {2} metais, jo darbinis turis yra {3} l, galia {4} KW ir automobilis yra nuvaziaves {5} km ",Marke, Modelis, Metai, DarbinisTuris, Galia, Rida );
            Console.WriteLine();
        }


    }
}

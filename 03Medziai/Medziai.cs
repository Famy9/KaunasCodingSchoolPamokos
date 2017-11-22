using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Medziai
{
    class Medziai
    {
        public string Rusis { get; private set; }
        public int Amzius { get; private set; }
        public int Aukstis { get; private set; }

        public Medis (string rusis, int amzius, int aukstis)
        {
            Rusis = rusis;
            Amzius = amzius;
            Aukstis = aukstis;
        }
        public void Isvedimas()
        {
            Console.WriteLine("{0} yra {1} metu amziaus ir {2} metru aukscio", Rusis,Amzius,Aukstis);
            Console.WriteLine();
        }
        public Medis 
    }
}

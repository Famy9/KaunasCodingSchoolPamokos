using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Zodziai
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> zodziai = new List<string>
            {
                "labas",
                "noriuValgyt",
                "noriuparukyti",
                "neisi",
                "la",
                "eiknx"
            };

            var trumpiausias = zodziai[0];
            var a = "";
            var g = 0;
            foreach (var zodis in zodziai)
            {
                if (zodis.Length < trumpiausias.Length)
                {
                    a = zodis;
                    
                }
              
            }

            var ilgiausias = zodziai[0];
            var b = "";
            var c = 0;
            foreach (var nezodis in zodziai)
            {
                if (nezodis.Length > trumpiausias.Length)
                {
                    b = nezodis;
                }
               
            }

            Console.WriteLine("trumpiausias zodis: " + a + " kuris yra: " + a.Length + " raidziu ilgio");
            Console.WriteLine("ilgiausias zodis: " + b + " kuris yra: " + b.Length +  " raidziu ilgio");
            Console.ReadKey();
        }
    }
}

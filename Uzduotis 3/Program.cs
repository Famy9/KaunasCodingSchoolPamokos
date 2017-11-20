using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite teigiama sakiciu: ");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("kas tau daros mazink apsisukimus");
            }

            if (a > 0)
            {
                Console.WriteLine("Saunuolis!!!!!!!!!!");
            }

            if (a % 2 == 0)
            {
                Console.WriteLine("lyginis");
            }

            if(a % 4 ==  0)
                {
                Console.WriteLine("skaicius dalinasi is 4");
            }
            if (a > 10 )
            {
                Console.WriteLine("skaicius yra didesinis uz 10");
            
            }
            Console.ReadKey();
        }
    }
}

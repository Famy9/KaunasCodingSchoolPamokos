using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite savo amziu: ");
            var a =Convert.ToInt32( Console.ReadLine());
            if (a >= 18)
                {
                Console.WriteLine("Jus galite eiti balsuoti");
                }
            if (a < 18)
            {
                Console.WriteLine("jus negalite eiti balsuoti");
            }
                Console.ReadKey();
        }
    }
}

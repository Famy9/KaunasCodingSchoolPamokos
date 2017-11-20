using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris savo pazymius: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var d = Convert.ToInt32(Console.ReadLine());
            var e = Convert.ToInt32(Console.ReadLine());
            var sum = (double)(a + b + c + d + e) / 2;


            if (sum >= 5)
            {
                Console.WriteLine("saunuolis bent jau teigiamas....");
            }
            else
            {
                Console.WriteLine("nevykelis");
            }
            if (true)
            {

            }

            Console.ReadKey();
        }
    }
}

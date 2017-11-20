using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04While_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite zodi arba exit:");

            var a = Console.ReadLine();
            var b = "";
            while (a != "exit")
            {
                var tekstas = "Iveskite zodi arba exit:";
                Console.WriteLine(tekstas + a);
                b += a;
                a = Console.ReadLine();

            }

            Console.WriteLine( b );
            Console.ReadKey();


        }
    }
}

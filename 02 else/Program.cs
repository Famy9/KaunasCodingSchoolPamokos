using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite norma skaiciu: ");

            var a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("skaiicus lyginis");
            }
            else if (a < 0)
            {
                Console.WriteLine("skaicius nelyginis");
            }
            else
            {
                Console.WriteLine("skaicius lygus 0");
            }
            Console.ReadKey();


        }
    }
}

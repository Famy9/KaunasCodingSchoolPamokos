using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ifai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite du skaicius: ");

            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            if (a > b || a == 0)
            {
                if (a > b)
                {
                    Console.WriteLine(a + "daugiau uz " + b);

                }
                else
                {
                    Console.WriteLine("{0} = 0", a);
                }
            }
            else if (b > a || b == 5)
            {
                if (b > a)
                {
                    Console.WriteLine(b + "daugiau uz " + b);
                }
                else
                {
                    Console.WriteLine(b + "lygus 0");
                }

            }
            if (a > b && a == 20)
                {
                    Console.WriteLine("a yra " + a);
                }
            else if (b > a && b < 100)
                {
                    Console.WriteLine("mazai mazai");
                }

            Console.ReadKey();

        }
    }
}

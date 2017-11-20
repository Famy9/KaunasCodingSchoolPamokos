using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite 3 skaicius: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("1 ir 2 yra lygus");
            }

            if (b == c)
            {
                Console.WriteLine("2 ir 3 yra lygus");
            }

            if (a > b)
            {
                Console.WriteLine("1 yradaugiau uz 2");
            }

            if (b == 2*c)
            {
                Console.WriteLine("2 yra lygus dviguabi 3 sanddaugai") ;
            }

            if (a % 2 == 0)
            {
                Console.WriteLine("1 yra lyginis");
            }

            if (b % 2 != 0)
            {
                Console.WriteLine("2 yra nelyginis ");
            }

            if (c > 0)
            {
                Console.WriteLine("3 yra teigiamas");
            }

            if (c < 0)
            {
                Console.WriteLine("3 yra neigiamas");
            }

            Console.ReadKey();
        }
    }
}

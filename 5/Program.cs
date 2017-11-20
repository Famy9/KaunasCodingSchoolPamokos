using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ener a key: ");
            var sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}*{1}={2}", sk, 1, sk * 1);
            Console.WriteLine("{0}*{1}={2}", sk, 2, sk * 2);
            Console.WriteLine("{0}*{1}={2}", sk, 3, sk * 3);
            Console.WriteLine("{0}*{1}={2}", sk, 4, sk * 4);
            Console.WriteLine("{0}*{1}={2}", sk, 5, sk * 5);
            Console.WriteLine("{0}*{1}={2}", sk, 6, sk * 6);
            Console.WriteLine("{0}*{1}={2}", sk, 7, sk * 7);
            Console.WriteLine("{0}*{1}={2}", sk, 8, sk * 8);
            Console.WriteLine("{0}*{1}={2}", sk, 9, sk * 9);
            Console.WriteLine("{0}*{1}={2}", sk, 10, sk * 10);
            Console.ReadKey();
        }
    }
}

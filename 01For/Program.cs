using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i += 3)
            {
                Console.WriteLine("[{0}]", i);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

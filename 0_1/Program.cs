using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int a1 = 0;
            int a2 = 0;

            for (int i = 0; i < 1000; i++)
            {
               

                if (i % 3 == 0)
                {
                    a1 = a1 + i;
                    Console.WriteLine(a);
                    
                }
                if (i % 5 == 0)
                {
                    a2 = a2 + i;
                    Console.WriteLine(a);
                }
                a = a1 + a2;

                
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}

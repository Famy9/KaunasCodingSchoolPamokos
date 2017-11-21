using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Masyvai
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = new int[10];
            int a = 0;
            var b = 1;
            var c = a + b;

            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                a = b;
                b = c;
                skaiciai[i] = c;

            }
            foreach (var skai in skaiciai)
            {
                Console.WriteLine(skai);
            }
            Console.ReadKey();
        }
    }
}

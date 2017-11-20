using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite teigiama sakiciu: ");
            var a = Convert.ToInt32(Console.ReadLine());
            
            if (a > 0)
            {


                while (a > 0)
                {
                    a--;
                    Console.WriteLine(a);
                }

            }
            Console.ReadKey();
        }
    }
}

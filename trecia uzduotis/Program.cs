using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trecia_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kokia temperatura?");
            var a = Convert.ToInt32(Console.ReadLine());


            if (a < 0)
            {
                Console.WriteLine("ziauriai salta");
            }

            else if (a < 10)
            {
                Console.WriteLine("labai salta");
            }

            else if (a < 20)
            {
                Console.WriteLine("salta");
            }
            else if (a < 30)
            {
                Console.WriteLine("normali temperatūra");
            }
            else if (a < 40)
            {
                Console.WriteLine("karšta");
            }
            else if (a > 40)
            {
                Console.WriteLine("visiškai degina");
            }
            Console.ReadKey()
        }
    }
}

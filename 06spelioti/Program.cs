using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06spelioti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atspek skaiciu nuo 1 iki 10!");
            Console.Write("Jusu pasirinkimas:");

            var a = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int b = random.Next(1, 11);
            Console.WriteLine(b);
            

            while (a != b)
            {
                if (a < b)
                {
                    Console.WriteLine("slaptas skaicius yra didesnis" );
                    Console.Write("Jusu pasirinkimas:");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                else if (a > b)
                {
                    Console.WriteLine("slaptas skaicius yra mazesnis");
                    Console.Write("Jusu pasirinkimas:");
                    a = Convert.ToInt32(Console.ReadLine());

                }

            }
            Console.WriteLine("sveikiname jus laimejote!!!!");



            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Jei rėžiai tinkami, tuomet
 * vykdyti for, kuris atskirose eilutėse 
išvestų kiekvieną skaičių iš tų rėžių, bei 
atskiriant tarpu - tų skaičių kvadratus.
*/
namespace _05For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite pradzia: ");

            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            if (b > a)
            {
                for (int c = a ; a < b; a++)
                {
                    Console.Write("{0}   ", a);
                    Console.WriteLine(a*a);
                }


            }
            else
            {
                Console.WriteLine("pabaiga");
            }

            Console.ReadKey();
        }
    }
}

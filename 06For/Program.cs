using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06For
{
    class Program
    {
        static void Main(string[] args)
        {/*Liepkite vartotojui įvesti rėžių pradžią ir pabaigą.
            Patikrinkite, kad tai būtų validu (pradžia turi būti 
            mažesnė nei pabaiga). Jei rėžiai tinkami, tuomet vykdyti for, 
            kuris iš duotų skaičių išvestų visus nelyginius skaičius arba
            tuos, kurie dalinasi iš 8.*/

            Console.WriteLine("iveskite pradzia: ");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("iveskite pabaiga: ");
            var b = Convert.ToInt32(Console.ReadLine());

            if (b > a)
            {
                Console.WriteLine("pradzia: "  );
                for (int i = a; i < b; i++)
                {
                    if (a % 2 != 0 || a % 8 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    
                }

            }
            else
            {
                Console.WriteLine("bandyk is naujo");
            }
            Console.ReadKey();
        }
    }
}

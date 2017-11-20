using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzaminas
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("iveskite 3 egzaminu rezultatus: ");

            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            double d = (a + b + c) / 3;
            Console.WriteLine("egzaminu rezultatu vidurkis yra " + d);

            if (d >= 8)
            { Console.WriteLine("Puiku!");
            }
            else if (d >= 5  )
                
                { Console.WriteLine("aj taip normaliai...");
            }
            else if (d > 5)
            { Console.WriteLine("nevykelis hahahahaha");
            }
            else
            { Console.WriteLine("laikei isvis egzus??");
            }
                Console.ReadKey();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ar norite pradeti: \n Taip/Ne");
            var atsakymas = Console.ReadLine();
            
            while (atsakymas == "Taip")
            {
                var a = Convert.ToInt32(Console.ReadLine());
                var b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                Console.WriteLine("{0} / {1} = {2}", a, b, a/b);



            }
        }
    }
}

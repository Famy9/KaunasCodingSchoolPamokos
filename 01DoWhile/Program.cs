using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite: ");
            int pasirinkimas;
            do
            {
                Console.WriteLine(" 1 - labas \n 2 - ate \n 3 - tu \n 4 - esi \n");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());
                if (pasirinkimas < 1 || pasirinkimas > 4)
                {
                    Console.WriteLine("blogai ivestas skaicius");
                }
            } while (pasirinkimas < 1 || pasirinkimas > 4);
            Console.WriteLine("pasirinkimas: " + pasirinkimas);



            Console.ReadKey();
        }
    }
}

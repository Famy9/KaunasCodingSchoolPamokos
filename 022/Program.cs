using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your lucky simbol: ");
            var simblo = Console.ReadLine();
            Console.WriteLine(simblo + simblo + simblo);
            Console.WriteLine(simblo + simblo + simblo);
            Console.WriteLine(simblo + simblo + simblo);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers: ");
            var num = Convert.ToInt32(Console.ReadLine());
            var nu = Convert.ToInt32(Console.ReadLine());
            var n = Convert.ToInt32(Console.ReadLine());
            float la = (num + nu + n) / 3;
            Console.WriteLine("Skaiciuas {0}, {1} ir {2} vidurkis yra: {3}",num , nu, n, la);
            Console.ReadKey();
        }
    }
}

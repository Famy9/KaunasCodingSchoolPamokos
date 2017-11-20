using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tell me your age: ");
            var skaicius = Console.ReadLine();
            Console.WriteLine("tell me your name: ");
            var name = Console.ReadLine();

            Console.WriteLine("your age is: " + skaicius);
            Console.WriteLine("your name is: " + name);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me a number: ");
            var value = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("your number to the power of two : {0} * {0} = {1}", value, value * value);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what's the temperature?");
            var C = Convert.ToInt32(Console.ReadLine());
            var F = C * 9 / 5 + 32;
            var K = C + 273.15;
            Console.WriteLine("Temperature in Celsius: {0}",C);
            Console.WriteLine("Temperature in Fahrenheit: {0}", F);
            Console.WriteLine("Temperature in Kelvin: {0}", K);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetika
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 9;
            var b = 5;
            var c = a + b;
            var d = a - b;
            var e = a * b;
            var f = a / b;
            var g = (double)a / b;
            var h = a % b;
            Console.WriteLine("{0} + {1} = {2}", a, b, c);
            Console.WriteLine("{0} - {1} = {2}", a, b, d);
            Console.WriteLine("{0} * {1} = {2}", a, b, e);
            Console.WriteLine("{0} / {1} = {2}", a, b, f);
            Console.WriteLine("{0} / {1} = {2}", a, b, g);
            Console.WriteLine("{0} % {1} = {2}", a, b, h);
            Console.ReadKey();
        }
    }
}

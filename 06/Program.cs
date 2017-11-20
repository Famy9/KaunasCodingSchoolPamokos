using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 25;
            var b = a % 10;
            var c = a / 10 % 10;
            
            Console.WriteLine("{0} skaiciaus skaitmenu sandauga: {1} ",a ,   b * c);
            Console.ReadKey();


        }
    }
}

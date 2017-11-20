using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers: ");
            var s1 = Convert.ToInt32(Console.ReadLine());
            var s2 = Convert.ToInt32(Console.ReadLine());
            var s3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} + {2} = {3}", s1, s2, s3, s1 + s2 + s3);
            Console.WriteLine("{0} - {1} - {2} = {3}", s1, s2, s3, s1 - s2 - s3);
            Console.WriteLine("{0} * {1} * {2} = {3}", s1, s2, s3, s1 * s2 * s3);
            Console.WriteLine("{0} / {1} / {2} = {3}", s1, s2, s3, s1 / s2 / s3);
            Console.ReadKey();
        }
    }
}

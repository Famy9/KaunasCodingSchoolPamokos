using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Msyvai
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new int[5];
            Console.WriteLine("Isveskite penkis skaicius");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i +1 + ": ");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());

            }

        }
    }
}

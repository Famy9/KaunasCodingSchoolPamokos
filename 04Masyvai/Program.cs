using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Masyvai
{
    class Program
    {
        static void Main(string[] args)
        {
            var pazymiai = new int[] { 8, 6, 7, 9, 10, 4, 5, 9, 2, 1, 10, 3, 7, 8, 8, 9, 10 };
            var geriausias = pazymiai[0];

            foreach (var geriausi in pazymiai)
            {
                if (geriausias < geriausi)
                {
                    geriausias = geriausi;
                }
            }

            Console.WriteLine(geriausias);

            var desimtukai = 0;

            foreach (var desimtukas in pazymiai)
            {
                if (desimtukas == 10)
                {
                    desimtukai++;

                }
            }
            Console.WriteLine(desimtukai);
            var neigiamas = 0;
            foreach (var neigiami in pazymiai)
            {
                if (neigiami < 4)
                {
                    neigiamas++;
                }
            }
            Console.WriteLine(neigiamas);

            var sumas = 0.0;

            foreach (var vidurkis in pazymiai)
            {
                sumas += vidurkis;
            }

            var vidurks = sumas / pazymiai.Length;
            Console.WriteLine("pazymiu vidurkis: " + vidurks);

            Console.ReadKey();
        }
    }
}

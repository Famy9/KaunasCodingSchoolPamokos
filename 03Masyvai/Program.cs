using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Masyvai
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperaturos = new int[] { 6,12,8,2,4,5,36,54,45,-82,-3 };
            var zemiausia = temperaturos[0];


            foreach (var temperatura in temperaturos)
            {
                if (temperatura < zemiausia)
                {
                    zemiausia = temperatura;
                }

                
            }
            Console.WriteLine(zemiausia);

            var auksciausia = temperaturos[0];
           
           

            foreach (var temperatura in temperaturos)
            {
                if (temperatura > auksciausia)
                {
                    auksciausia = temperatura;
                }
            }
            Console.WriteLine(auksciausia);

            var suma = 0.0;

            foreach (var skaicius in temperaturos)
            {
                suma += skaicius;

            }

            var vidurkis = suma / temperaturos.Length;

            Console.WriteLine("vidurkis: " + vidurkis);

            var maziausios = 0;


            foreach (var mazesnis in temperaturos)
            {
                if (mazesnis < vidurkis)
                {
                    maziausios++;
                }

            }
            Console.WriteLine(maziausios);

            var didziausios = 0;


            foreach (var didesnis in temperaturos)
            {
                if (didesnis > vidurkis)
                {
                    didziausios++;
                }

            }
            Console.WriteLine(didziausios);


            Console.ReadKey();
        }
    }
}

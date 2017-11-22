 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Masinos
{
    class Program
    {
        static void Main(string[] args)
        {
            var auto = new automobiliai("audine", "A6", 1958, 4, 600, 9000);
            auto.Isvedimas();

            var automobilis = new List <automobiliai>
            {
                new automobilis("BMW", "X6", 2016, 5, 500, 1000),
                new automobilis2("Lada", "CUper", 1960, 2, 30, 3000000 ),
                new automobilis3("Mercedez_Benz", "S Class", 2004, 3, 400, 564456000),
                new automobilis4("Toyota", "Corola", 2006, 1, 320, 1000654),
                new automobilis5("Citroen", "C5", 1930, 2.2, 150, 321000),
            }
        }

    }
}

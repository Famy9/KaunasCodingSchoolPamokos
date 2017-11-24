using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Paveldejimai
{
    class Program
    {
        static void Main(string[] args)
        {
            var darbuotojas = new Darbuotojas("Matas", "Lataitis", 20, 1500, 1);
            darbuotojas.Isvedimas();
            Console.WriteLine();

            var policininkas = new Policinkas("Labas", "Ate", 45, 300, 0.5, 6000, 2);
            policininkas.Isvedimas();
        }
    }
}

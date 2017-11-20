using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12For
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            var b = 1;
            var c = a + b;

            for (int i = 0; i < x; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
            Console.ReadKey();


        }
    }
}


/*(Pažengusiems) Parašyti for ciklą, kuris leistų vartotojui pasirinkti kiek fibonačiaus skaičių išvesti į ekraną.
 Fibonačiaus sekoje kiekvienas skaičius yra lygus prieš jį ėjusių dviejų skaičių sumai: 1 1 2 3 5 8 11...
Susikurkite tris sveikųjų skaičių kintamuosius, kurie jums padės tai pasiekti.
Pirmi du kintamieji saugos paskutinius du skaičius.
Trečiasis bus šių pirmų dviejų skaičių suma.
Pirmus du skaičius išveskite ne cikle, o prieš jį ir ciklą pradėkite vykdyti nuo 2, o ne nuo 0.
Kiekvieno ciklo metu turite perskaičiuot trečiąjį skaičių (pirmų dviejų skaičių sudėtis), tuomet pirmasis skaičius 
yra lygus antram, o antrasis lygus trečiam, išvesti į ekraną trečią skaičių.
*/
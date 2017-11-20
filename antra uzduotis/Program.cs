using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antra_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk savo rezultata asile: ");
            var rezas = Convert.ToInt32(Console.ReadLine());

            if (rezas == 0)
            {
                Console.WriteLine("saunuolis simtukas");
            }
            else if (rezas >= 80)
            {
                Console.WriteLine("neblogai visai");
            }
            else if (rezas >= 50)
            {
                Console.WriteLine("neblogai");
            }
            else if (rezas >= 20)
            {
                Console.WriteLine("prastai");
            }
            else if (rezas < 20 )
            {
                Console.WriteLine("neislaikyta");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kepykla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, \n \n ");
            var t = 8; // darbo valandos

            Console.WriteLine("Kiek darbuotojas gali iškepti kepalų per valandą?" );
            var greitis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek darbuotojų turi kepykla?");
            var darbuotojai = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vieno kepalo savikaina?");
            var savikaina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vieno kepalo pardavimo kaina?");
            var kaina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek kepykla turi tą dieną užsakymų?");
            var uzsakymai = Convert.ToInt32(Console.ReadLine());

            var per_diena_iskepa = t * greitis * darbuotojai;
            Console.WriteLine("per diena iskepama: " + per_diena_iskepa);

            var savikaina_dienos = per_diena_iskepa * savikaina;
            Console.WriteLine("per diena iskeptos duonos savikaina: " + savikaina_dienos);

            var pajamos = per_diena_iskepa * kaina;
            Console.WriteLine("per diena uzdirbama: "+ pajamos);

            var pelnas = pajamos - savikaina_dienos;
            Console.WriteLine("grynas pelnas: "+ pelnas);

            if (per_diena_iskepa > uzsakymai)
            {
                Console.WriteLine("sveikiname jus ivykdete dienos norma!!!");
            }
            else
            {
                Console.WriteLine("jums dar truksta: " + (uzsakymai - per_diena_iskepa));
            }
            Console.ReadKey();
        }
    }
}

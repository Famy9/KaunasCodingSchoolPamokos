using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki,\n \n pasirinkite: \n 1 - vanduo \n 2 - kava \n 3 - narkotikai");
            var a =Convert.ToInt32( Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Jus pasirinkote vandeni!");
                    break;
                case 2:
                    Console.WriteLine("Jus pasirinkote kava!");
                    break;
                case 3:
                    Console.WriteLine("Jus pasirinkote narkotikus :)");
                    break;
                default:
                    Console.WriteLine("tokio pasirinkimo nera");
                    break;
            }




            Console.ReadKey();
        }
    }
}

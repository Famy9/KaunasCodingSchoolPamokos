using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Method
{
    class Program
    {
        static void Main(string[] args)
        {
            StatinisMetodas();
            Console.ReadKey();
        }

        public void Atsisveikinimai()
        {
            Console.WriteLine("Iki pasimatymo ;)");
        }
        public void Atsisveikinti(string Ate)
        {
            Console.WriteLine("iki pasimatymo " + Ate);

        }
        public void Atsisveikinimai(string Ate, string Ciau)
        {
            Console.WriteLine("ciau bambino " + Ate + " " + Ciau);
        }


        public static void StatinisMetodas()
        {
            Console.WriteLine("statinis Metodas");
        }



    }


}

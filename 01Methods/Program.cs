
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Pasisveikinimai();
            programa.Pasisveikinti("Ieva");
            programa.Pasisviekiniti("Matas", "Lataitis");
            Console.ReadKey();
        }

        public void Pasisveikinimai()
        {
            Console.WriteLine("Labas Gaidy ");

        }
        public void Pasisveikinti(string vardas)
        {
            Console.WriteLine("Labas " + vardas);

        }
        public void Pasisviekiniti(string vardas, string pavarde)
        {
            Console.WriteLine("Labas, " + vardas + " " + pavarde);
        }

    }
}

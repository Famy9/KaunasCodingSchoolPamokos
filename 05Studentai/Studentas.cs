using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Studentai
{
    class Studentas
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public string Pravarde { get; private set; }
        public int Amzius { get; private set; }
        public List<int> MatematikosPazymiai { get; private set; }
        public List<int> InformatikosPazymiai { get; private set; }
        public List<int> GeografijosPazymiai { get; private set; }

        public Studentas(string vardas, string pavarde, string pravarde, int amzius, List<int> matematikosPazymiai, List<int> informatikosPazymiai, List<int> geografijosPazymiai)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Pravarde = pravarde;
            Amzius = amzius;
            MatematikosPazymiai = matematikosPazymiai;
            InformatikosPazymiai = informatikosPazymiai;
            GeografijosPazymiai = geografijosPazymiai;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Studentas: {0}{1}({2}m.)", Vardas,Pavarde,Amzius);
            Console.WriteLine("Turi {0} pravarde", Pravarde);
            Console.WriteLine("Matematikos Pazimys: ");
            foreach (var i in MatematikosPazymiai)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Informatikos Pazimys: ");
            foreach (var a in InformatikosPazymiai)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Geografijos Pazimys: ");
            foreach (var b in GeografijosPazymiai)
            {
                Console.Write(b + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Bico pazymiu vidurkis: " +Math.Round(Vidurkis(),2));
        }

        public double Vidurkis()
        {
            return (MatematikosPazymiai.Average()+InformatikosPazymiai.Average()+ GeografijosPazymiai.Average())/3;

        }
         
        public int DidziausiasPazymys()
        {
            var pirmas = MatematikosPazymiai.Max();
            var antras = GeografijosPazymiai.Max();
            var trecias = InformatikosPazymiai.Max();

            if (pirmas > antras && pirmas > antras)
            {
                return pirmas;
            }

            if (antras > pirmas && antras > trecias)
            {
                return antras;
            }

            if (trecias > pirmas && trecias > antras)
            {
                return trecias;
            }

            return pirmas;

        }


    }
}

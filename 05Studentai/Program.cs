using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Studentai
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentas = new Studentas("Hobitas", "Lopas", "Ryzas", 5000, new List<int>
            {
                10,5,6,4,3,8,2,7,9
            }, new List<int>
            {
                5,8,3,7,9,1,10,10,10,10,9
            }, new List<int>
            {
                8,8,8,8,8,8,8,8,8,8,8,8,8,8,9,9,9,9,9,3,3,3,5,4,4,4,4,4,
            }
            );

            studentas.Isvedimas();0
        }
    }
}

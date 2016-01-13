
//Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus7
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi;
            Console.Write("vuosi");
            vuosi = int.Parse(Console.ReadLine());
            Console.WriteLine("vuotesi   " + vuosi);
            if (vuosi % 4 == 0 && vuosi % 100 != 0 || vuosi % 400 == 0)
            {

                Console.WriteLine("karkausvuosi");

            }
            else
                Console.WriteLine("eipa oo karkausvuosi");

            

        }
    }
}

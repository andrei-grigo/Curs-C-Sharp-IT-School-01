using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    public class Tema01App
    {
        public string Cerinta = "Cititi trei numere si afisati daca toate sunt pozitive";
        public void Launch()
        {
            int a1, b2, c3;
            Console.Write("Introdu primul numar: ");
            string a1Input = Console.ReadLine();
            bool a1Valid = int.TryParse(a1Input, out a1);

            while (!a1Valid)
            {
                Console.WriteLine("Caracterul introdus nu este un numar, incearca din nou!");
                Console.Write("Introdu primul numar: ");
                a1Input = Console.ReadLine();
                a1Valid = int.TryParse(a1Input, out a1);
            }

            Console.Write("Introdu al doilea numar: ");
            string b2Input = Console.ReadLine();
            bool b2Valid = int.TryParse(b2Input, out b2);

            while (!b2Valid)
            {
                Console.WriteLine("Caracterul introdus nu este un numar, incearca din nou!");
                Console.Write("Introdu al doilea numar: ");
                b2Input = Console.ReadLine();
                b2Valid = int.TryParse(b2Input, out b2);
            }

            Console.Write("Introdu al treilea numar: ");
            string c3Input = Console.ReadLine();
            bool c3Valid = int.TryParse(c3Input, out c3);

            while (!c3Valid)
            {
                Console.WriteLine("Caracterul introdus nu este un numar, incearca din nou!");
                Console.Write("Introdu al treilea numar: ");
                c3Input = Console.ReadLine();
                c3Valid = int.TryParse(c3Input, out c3);
            }

            if ((a1 >= 0) && (b2 >= 0) && (c3 >= 0))
            {
                Console.Write("Toate numerele sunt pozitive ");
            }
            else
            {
                Console.Write("Unul sau mai multe numerele nu sunt pozitive ");
            }
        }

    }
}

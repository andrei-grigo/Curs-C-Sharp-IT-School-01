using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema04
{
    internal class Tema04App
    {
        public string Cerinta = "Cititi trei numere si afisati-l pe cel mai mare dintre ele";
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
                c3Valid = int.TryParse(a1Input, out c3);
            }

            if ((a1 > b2) && (a1 > c3))
            {
                Console.Write($"{a1} este mai mare decat celelalte doua");
            }
            else if ((b2 > a1) && (b2 > c3))
            {
                Console.Write($"{b2} este mai mare decat celelalte doua");
            }
            else Console.Write($"{c3} este mai mare decat celelalte doua");
        }
    }
}

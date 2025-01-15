using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema03
{
    public class Tema03App
    {
        public string Cerinta = "Cititi doua numere si afisati-l pe cel mai mare dintre ele.";
        public void Launch()
        {
            int a1, b2;
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

            if (a1 > b2)
            {
                Console.WriteLine($"{a1} este cel mai mare si mai tare!!!");
            }
            else if (b2 > a1)
            {
                Console.WriteLine($"{b2} este cel mai mare si mai tare!!!");
            }
            else Console.WriteLine($"{a1} si {b2} par sa fie egale :)");
        }
    }
}

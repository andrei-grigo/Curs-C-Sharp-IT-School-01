using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema02
{
    public class Tema02App
    {
        public string Cerinta = "Cititi un numar si afisati “Pozitiv” daca numarul este mai mare decat 0, “Negativ” daca este mai mic decat 0 si “Zero” daca este egal cu 0.";
        public void Launch()
        {
            int X;
            Console.Write("Introdu un numar: ");
            string Xinput = Console.ReadLine();
            bool Xvalid = int.TryParse(Xinput, out X);

            while (!Xvalid)
            {
                Console.WriteLine("Caracterul introdus nu este un numar, incearca din nou!");
                Console.Write("Introdu un numar: ");
                Xinput = Console.ReadLine();
                Xvalid = int.TryParse(Xinput, out X);
            }
            if (X > 0)
            {
                Console.Write("Pozitiv");
            }
            else if (X < 0)
            {
                Console.Write("Negativ");
            }
            else
            {
                Console.Write("Zero");
            }
        }
    }
}

using ITSchool.AppUtilities;

namespace App04
{
    public class Application04 : ApplicationBase
    {
        public Application04() : base()
        {
            Cerinta = "Introduceti doua numere si afisati daca primul este mai mare decat al doilea.";
        }
        public override void Launch()
        {
            int a = Utils.GetIntFromKeyboard();
            int b = Utils.GetIntFromKeyboard();

            if (a > b)
            {
                Console.WriteLine($"{a} este mai mare decat {b}");
            }
            else if (a == b)
            {
                Console.WriteLine($"{a} este egal cu {b}");
            }
            else
            {
                Console.WriteLine($"{a} este mai mic decat {b}");
            }
        }
    }
}
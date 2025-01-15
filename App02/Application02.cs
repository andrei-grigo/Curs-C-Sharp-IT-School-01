using ITSchool.AppUtilities;

namespace App02
{
    public class Application02 : ApplicationBase
    {
        public Application02() : base()
        {
            Cerinta = "Intoduceti doua numere pentru a afla produsul lor.";
        }
        public override void Launch()
        {
            int a = Utils.GetIntFromKeyboard();
            int b = Utils.GetIntFromKeyboard();

            Console.WriteLine($"Produsul dintre numerele {a} si {b} este: {a * b}");
        }
    }
}
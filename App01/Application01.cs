using ITSchool.AppUtilities;

namespace App01
{
    public class Application01 : ApplicationBase
    {
        public Application01() : base()
        {
            Cerinta = "Intoduceti doua numere pentru a afla suma lor.";
        }
        public override void Launch()
        {
            int a = Utils.GetIntFromKeyboard("A");
            int b = Utils.GetIntFromKeyboard("B");
            Console.WriteLine($"Suma numerelor {a} si {b} este: {a + b}");
        }
    }
}
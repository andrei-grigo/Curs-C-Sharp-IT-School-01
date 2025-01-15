using ITSchool.AppUtilities;

namespace App08
{
    public class Application08 : ApplicationBase
    {
        public Application08() : base()
        {
            Cerinta = "Cititi un numar si calculati factorialul acestuia (n! = n * (n-1) * (n-2) *...* 1).";
        }
        public override void Launch()
        {
            int a = Utils.GetIntFromKeyboard("\"N\"");
            int produs = 1;

            for (int i = a; i > 0; i--)
            {
                produs *= i;
            }
            Console.WriteLine($"{a}! = {produs}");
        }
    }
}
using ITSchool.AppUtilities;

namespace App05
{
    public class Application05 : ApplicationBase
    {
        public Application05() : base()
        {
            Cerinta = "Cititi un numar si verificati daca este par sau impar.";
        }
        public override void Launch()
        {
            int a = Utils.GetIntFromKeyboard();

            if (a % 2 == 0)
            {
                Console.WriteLine($"Numarul {a} este par!");
            }
            else
            {
                Console.WriteLine($"Numarul {a} este impar!");
            }
        }
    }
}
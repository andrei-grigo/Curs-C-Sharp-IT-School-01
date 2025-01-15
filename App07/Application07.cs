using ITSchool.AppUtilities;

namespace App07
{
    public class Application07 : ApplicationBase
    {
        public Application07() : base()
        {
            Cerinta = "Cititi un numar \"N\" si calculati suma numerelor naturale de la 1 la \"N\".";
        }
        public override void Launch()
        {
            int a = Utils.GetIntFromKeyboard("\"N\"");
            int suma = 0;

            for (int i = 0; i <= a; i++)
            {
                suma += i;
            }
            Console.WriteLine($"Suma primelor n numere naturale este {suma}");
        }
    }
}
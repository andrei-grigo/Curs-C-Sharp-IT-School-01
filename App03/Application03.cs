using ITSchool.AppUtilities;

namespace App03
{
    public class Application03 : ApplicationBase
    {
        public Application03() : base()
        {
            Cerinta = "Introduceti un numar pentru a afla patratul acestuia.";
        }
        public override void Launch()
        {
            int a = Utils.GetIntFromKeyboard();

            Console.WriteLine($"Patratul lui {a} este: {a * a}");
        }
    }
}
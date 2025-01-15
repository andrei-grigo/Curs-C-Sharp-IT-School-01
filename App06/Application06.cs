using ITSchool.AppUtilities;

namespace App06
{
    public class Application06 : ApplicationBase
    {
        public Application06() : base()
        {
            Cerinta = "Cititi un numar si afisati toate numerele de la 1 la \"N\".";
        }
        public override void Launch()
        {
            int a = Utils.GetIntFromKeyboard("\"N\"");

            for (int index = 1; index <= a; index++)
            {
                Console.Write(index + ", ");
            }
        }
    }
}
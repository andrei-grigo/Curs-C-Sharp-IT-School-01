using ITSchool.AppUtilities;

namespace App09
{
    public class Application09 : ApplicationBase
    {
        public Application09() : base()
        {
            Cerinta = "Afisati toate numerele pare de la 1 la 100 folosind o bucla pentru.";
        }
        public override void Launch()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Numarul {i} este par.");
                }
            }

        }
    }
}
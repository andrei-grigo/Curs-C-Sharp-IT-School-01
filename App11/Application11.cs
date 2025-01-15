using ITSchool.AppUtilities;

namespace App11
{
    public class Application11 : ApplicationBase
    {
        public Application11() : base()
        {
            Cerinta = "Realizati un generator de numere naturale random." +
            "\nVeti indica numarul de elemente si intervalul in care acestea pot avea valori." +
            "\nValorile vor fi stocate intr-un array iar la final vor fi afisate in consola.";
        }
        public override void Launch()
        {
            //dam nr de elemente pt sir
            int a = Utils.GetIntFromKeyboard("numarul de elemente pentru sir: ");

            //indicati intervalul in care putem avea valori
            const int limitaInferioara = -10;
            const int limitaSuperioara = 10;

            int[] arrayDeNumere = new int[a];

            Random genRandomNr = new Random();

            //generam valori aleatoare pentru fiecare pozitie din array
            for (int i = 0; i < arrayDeNumere.Length; i++)
            {
                //atribuim un nr aleator pentru pozitia curenta
                arrayDeNumere[i] = genRandomNr.Next(limitaInferioara, limitaSuperioara + 1);
                Console.Write(arrayDeNumere[i] + ", ");
            }
        }
    }
}
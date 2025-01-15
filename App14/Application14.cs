using ITSchool.AppUtilities;

namespace App14
{
    public class Application14 : ApplicationBase
    {
        public Application14() : base()
        {
            Cerinta = "Afisati toate numerele prime dintr-un sir de numere intregi (generat la App11)." +
            "\nUn numar este prim daca acesta se imparte fara rest doar la 1 si la el insusi" +
            "\nIgnorati orice numar din sir care este -1, 0 sau 1." +
            "\nConsiderati si numerele negative ca fiind prime.";
        }
        public override void Launch()
        {
            int[] arrayDeIntrare = GetRandomGenArray(-100, 100);
            for (int i = 0; i < arrayDeIntrare.Length; i++)
            {
                if (arrayDeIntrare[i] == -1 || arrayDeIntrare[i] == 0 || arrayDeIntrare[i] == 1)
                {
                    continue;
                }

                if (VerificaNrPrim(arrayDeIntrare[i]))
                {
                    Console.WriteLine(arrayDeIntrare[i] + " este prim");
                }
            }

            bool VerificaNrPrim(int numar)
            {
                int copie = numar;

                if (copie < 0)
                {
                    copie *= -1;
                }

                for (int i = 2; i < numar; i++)
                {
                    if (numar % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            int[] GetRandomGenArray(int limitaInferioara, int limitaSuperioara)
            {
                int a;
                Console.Write("Introduceti numarul de elemente pentru sir: ");
                string aInput = Console.ReadLine();
                bool aValid = int.TryParse(aInput, out a);

                while (!aValid || a <= 0)
                {
                    Console.WriteLine("Date incorecte!");
                    Console.Write("Introduceti numarul de elemente pentru sir: ");
                    aInput = Console.ReadLine();
                    aValid = int.TryParse(aInput, out a);
                }

                int[] arrayDeNumere = new int[a];

                Random genRandomNr = new Random();

                //generam valori aleatoare pentru fiecare pozitie din array
                for (int i = 0; i < arrayDeNumere.Length; i++)
                {
                    //atribuim un nr aleator pentru pozitia curenta
                    arrayDeNumere[i] = genRandomNr.Next(limitaInferioara, limitaSuperioara + 1);
                    Console.Write(arrayDeNumere[i] + ", ");
                }
                Console.WriteLine();
                return arrayDeNumere;
            }
        }
    }
}
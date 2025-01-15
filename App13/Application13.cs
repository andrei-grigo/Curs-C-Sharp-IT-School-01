using ITSchool.AppUtilities;

namespace App13
{
    public class Application13 : ApplicationBase
    {
        public Application13() : base()
        {
            Cerinta = "Calculati suma numerelor pozitive dintr-un sir de numere intregi (generat in App11)." +
            "\nFolositi cheia “continue” pentru a sari peste numerele negative.";
        }
        public override void Launch()
        {
            int[] arrayDeIntrare = GetRandomGenArray(-10, 10);

            int suma = 0;

            for (int i = 0; i < arrayDeIntrare.Length; i++)
            {
                //daca nr este negativ, ignora-l
                if (arrayDeIntrare[i] < 0)
                {
                    continue;
                }

                suma += arrayDeIntrare[i];
            }

            Console.WriteLine("Suma numerelor pozitive din array-ul primit este: " + suma);

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
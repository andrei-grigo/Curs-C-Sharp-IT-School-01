using ITSchool.AppUtilities;

namespace App12
{
    public class Application12 : ApplicationBase
    {
        public Application12() : base()
        {
            Cerinta = "Introduceti un numar de la tastatura." +
            "\nNumarul trebuie sa fie in intervalul definit in App11." +
            "\nCautati numarul introdus in colectia generata in App11." +
            "\nDaca il gasiti, afisati poziţia lui si intrerupeti funcţionarea metodei, altfel afisati un mesaj corespunzator lipsei lui." +
            "\nHint: cheia “break” intrerupe rularea unei structuri repetitive.";
        }
        public override void Launch()
        {//dam nr de elemente pt sir
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
            Console.WriteLine();
            //================================= cod copiat de la A11

            // Validare date de la tastatura

            bool numarGasit = false;
            int b = Utils.GetIntFromKeyboard();
            Console.Write("Introduceti un numar intre -10 si 10: ");

            do
            {
                Console.WriteLine("Date incorecte");
                Console.Write("Introduceti un numar intre -10 si 10: ");
            }
            while (b > 10 || b < -10);


            // Cautarea pozitiei numarului citit in array

            for (int j = 0; j < arrayDeNumere.Length; j++)
            {
                if (arrayDeNumere[j] == b)
                {
                    Console.WriteLine($"Numarul {b} a fost gasit pe pozitia {j}");
                    numarGasit = true;
                    break;
                }
            }
            if (numarGasit == false)
            {
                Console.WriteLine($"Numarul {b} NU a fost gasit in sirul de mai sus");
            }
        }
    }
}
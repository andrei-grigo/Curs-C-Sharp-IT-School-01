namespace ITSchool.AppUtilities
{
    public class Utils
    {
        public static int GetIntFromKeyboard(string denumire = "")
        {
            int a;
            bool aValid;
            string nume = "";
            if (!string.IsNullOrEmpty(denumire))
            {
                nume = " pentru " + denumire;
            }
                do
                {
                    Console.Write($"Introduceti un numar intreg{nume}: ");
                    aValid = int.TryParse(Console.ReadLine(), out a);

                    if (!aValid)
                    {
                        Console.WriteLine("Datale introduse nu sunt valide!");
                    }
                } while (!aValid);

                return a;
        }

        public static int[] GenArrayDeNrIntregi(int dimensiuneArray, int limitaInferioara, int limitaSuperioara)
        {
            Random genRandomNr = new Random();

            int[] arrayDeNumere = new int[dimensiuneArray];

            for (int i = 0; i < arrayDeNumere.Length; i++)
            {
                arrayDeNumere[i] = genRandomNr.Next(limitaInferioara, limitaSuperioara + 1);
            }

            return arrayDeNumere;
        }
    }
}
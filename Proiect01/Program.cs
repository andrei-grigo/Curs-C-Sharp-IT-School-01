namespace Proiect01
{
    internal class Program
    {
        public static ListaCumparaturi Lista;

        private static void Main(string[] args)
        {
            Lista = new ListaCumparaturi();
            Lista.DeCumparat.Add(new Produs("Branza", 1));
            Lista.DeCumparat.Add(new Produs("Carne", 1));
            Lista.DeCumparat.Add(new Produs("Lapte", 1));
            Lista.DeCumparat.Add(new Produs("Oua", 1));
            Lista.DeCumparat.Add(new Produs("Faina", 1));
            Lista.DeCumparat.Add(new Produs("Cafea", 1));

            Lista.DeCumparat[0].EsteCumparat = true;
            Lista.Achizitionate.Add(Lista.DeCumparat[0]);
            Lista.DeCumparat.RemoveAt(0);

            Lista.DeCumparat[2].EsteCumparat = true;
            Lista.Achizitionate.Add(Lista.DeCumparat[2]);
            Lista.DeCumparat.RemoveAt(2);

            while (true)
            {
                Console.Clear();
                Lista.AfiseazaLista();
                int a;
                bool aValid;
                do
                {
                    Console.Write("\nMENIU PRINCIPAL:\n1: Adauga produs\n2: Sterge produs\n3: Cauta produs\n4: Afiseaza produsele cumparate\n5: Marcheaza un produs cumparat\n\n0: Iesire\n\nSelecteaza o optiune: ");
                    aValid = int.TryParse(Console.ReadLine(), out a);

                    if (!aValid || a > 5 || a < 0)
                    {
                        Console.WriteLine("Datele introduse nu sunt valide!");
                    }
                } while (!aValid || a > 5 || a < 0);

                switch (a)
                {
                    case 0: return;
                    case 1:
                        Functii.AdaugaProdus();
                        break;
                    case 2:
                        Functii.StergeProdus();
                        break;
                    case 3:
                        Functii.CautaProdus();
                        break;
                    case 4:
                        Console.Clear();
                        Lista.AfiseazaListaCumparate();
                        break;
                    case 5:
                        Functii.ProdusCumparat();
                        break;
                }
            }
        }
    }
}
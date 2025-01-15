namespace Proiect01
{
    public static class Functii
    {
        public static void AdaugaProdus()
        {
            Console.WriteLine();
            string? numeProdus;
            do
            {
                Console.Write("Scrie numele produsului: ");
                numeProdus = Console.ReadLine();
            } while (string.IsNullOrEmpty(numeProdus));

            int cantitateProdus;
            bool cantitateProdusValid;
            do
            {
                Console.Write("Adauga cantitatea dorita: ");
                cantitateProdusValid = int.TryParse(Console.ReadLine(), out cantitateProdus);

                if (!cantitateProdusValid || cantitateProdus < 1)
                {
                    Console.WriteLine("Datele introduse nu sunt valide!");
                }
            } while (!cantitateProdusValid || cantitateProdus < 1);

            Program.Lista.DeCumparat.Add(new Produs(numeProdus, cantitateProdus));
        }

        public static void StergeProdus()
        {
            Console.WriteLine();
            Console.WriteLine("Cum doresti sa stergi produsul?");
            Console.WriteLine("1: Dupa numar (index)");
            Console.WriteLine("2: Dupa nume");

            int optiuneStergere;
            bool optiuneValid;
            do
            {
                Console.Write("Alege optiunea (1 sau 2): ");
                optiuneValid = int.TryParse(Console.ReadLine(), out optiuneStergere);
                if (!optiuneValid || (optiuneStergere != 1 && optiuneStergere != 2))
                {
                    Console.WriteLine("Optiune invalida! Alege 1 sau 2.");
                }
            } while (!optiuneValid || (optiuneStergere != 1 && optiuneStergere != 2));

            if (optiuneStergere == 1)
            {
                int produsStersIndex;
                bool produsStersIndexValid;

                do
                {
                    Console.Write("Scrie numarul produsului pentru a fi sters: ");
                    produsStersIndexValid = int.TryParse(Console.ReadLine(), out produsStersIndex);

                    if (!produsStersIndexValid || produsStersIndex < 1 || produsStersIndex > Program.Lista.DeCumparat.Count)
                    {
                        Console.WriteLine("Datele introduse nu sunt valide! Introdu un numar corect.");
                    }
                } while (!produsStersIndexValid || produsStersIndex < 1 || produsStersIndex > Program.Lista.DeCumparat.Count);

                Program.Lista.DeCumparat.RemoveAt(produsStersIndex - 1);
                Console.WriteLine("Produsul a fost sters.");
            }
            else if (optiuneStergere == 2)
            {
                Console.Write("Scrie numele produsului pe care doresti sa-l stergi: ");
                string numeProdusStergere = Console.ReadLine().ToLower();

                bool produsGasit = false;

                for (int i = 0; i < Program.Lista.DeCumparat.Count; i++)
                {
                    if (Program.Lista.DeCumparat[i].Denumire.ToLower() == numeProdusStergere)
                    {
                        Program.Lista.DeCumparat.RemoveAt(i);
                        Console.WriteLine($"Produsul {numeProdusStergere} a fost sters.");
                        produsGasit = true;
                        break;
                    }
                }

                if (!produsGasit)
                {
                    Console.WriteLine("Produsul nu a fost gasit in lista de cumparat.");
                }
            }
            Console.WriteLine("\nApasa orice tasta pentru a reveni la meniul principal...");
            Console.ReadKey();
        }

        public static void ProdusCumparat()
        {
            Console.WriteLine();
            Console.WriteLine("Cum doresti sa marchezi produsul ca si cumparat?");
            Console.WriteLine("1: Dupa numar (index)");
            Console.WriteLine("2: Dupa nume");

            int optiune;
            bool optiuneValid;
            do
            {
                Console.Write("Alege optiunea (1 sau 2): ");
                optiuneValid = int.TryParse(Console.ReadLine(), out optiune);

                if (!optiuneValid || (optiune != 1 && optiune != 2))
                {
                    Console.WriteLine("Optiune invalida, te rog alege 1 sau 2.");
                }
            } while (!optiuneValid || (optiune != 1 && optiune != 2));

            if (optiune == 1)
            {
                int produsIndex;
                bool produsIndexValid;
                do
                {
                    Console.Write("Scrie numarul produsului (indexul) pe care doresti sa-l marchezi ca si cumparat: ");
                    produsIndexValid = int.TryParse(Console.ReadLine(), out produsIndex);

                    if (!produsIndexValid || produsIndex < 1 || produsIndex > Program.Lista.DeCumparat.Count)
                    {
                        Console.WriteLine("Numar invalid, te rog alege un numar valid.");
                    }
                } while (!produsIndexValid || produsIndex < 1 || produsIndex > Program.Lista.DeCumparat.Count);

                Produs produs = Program.Lista.DeCumparat[produsIndex - 1];
                Program.Lista.DeCumparat.RemoveAt(produsIndex - 1);
                Program.Lista.Achizitionate.Add(produs);
                Console.WriteLine($"Produsul {produs.Denumire} a fost marcat ca achizitionat.");
            }
            else if (optiune == 2)
            {
                Console.Write("Scrie numele produsului pe care doresti sa-l marchezi ca si cumparat: ");
                string numeProdus = Console.ReadLine();

                bool gasit = false;

                for (int i = 0; i < Program.Lista.DeCumparat.Count; i++)
                {
                    if (Program.Lista.DeCumparat[i].Denumire.ToLower() == numeProdus.ToLower())
                    {
                        Produs produs = Program.Lista.DeCumparat[i];
                        Program.Lista.DeCumparat.RemoveAt(i);
                        Program.Lista.Achizitionate.Add(produs);
                        Console.WriteLine($"Produsul {produs.Denumire} a fost marcat ca achizitionat.");
                        gasit = true;
                        break;
                    }
                }

                if (!gasit)
                {
                    Console.WriteLine("Produsul nu a fost gasit in lista de cumparat.");
                }
            }

            Console.WriteLine("\nApasa orice tasta pentru a reveni la meniul principal...");
            Console.ReadKey();
        }

        public static void CautaProdus()
        {
            Console.WriteLine();
            Console.WriteLine("Cum doresti sa cauti un produs?");
            Console.WriteLine("1: Dupa numar (index)");
            Console.WriteLine("2: Dupa nume");

            int optiune;
            bool optiuneValid;
            do
            {
                Console.Write("Alege optiunea (1 sau 2): ");
                optiuneValid = int.TryParse(Console.ReadLine(), out optiune);

                if (!optiuneValid || (optiune != 1 && optiune != 2))
                {
                    Console.WriteLine("Optiune invalida, te rog alege 1 sau 2.");
                }
            } while (!optiuneValid || (optiune != 1 && optiune != 2));

            if (optiune == 1)
            {
                int produsIndex;
                bool produsIndexValid;
                do
                {
                    Console.Write("Scrie numarul produsului (indexul): ");
                    produsIndexValid = int.TryParse(Console.ReadLine(), out produsIndex);

                    if (!produsIndexValid || produsIndex < 1 || produsIndex > Program.Lista.DeCumparat.Count)
                    {
                        Console.WriteLine("Numar invalid, te rog alege un numar valid.");
                    }
                } while (!produsIndexValid || produsIndex < 1 || produsIndex > Program.Lista.DeCumparat.Count);

                Produs produs = null;
                if (produsIndex <= Program.Lista.DeCumparat.Count)
                {
                    produs = Program.Lista.DeCumparat[produsIndex - 1];
                }
                else
                {
                    produs = Program.Lista.Achizitionate[produsIndex - Program.Lista.DeCumparat.Count - 1];
                }

                Console.WriteLine($"Produsul gasit este: {produs.GetData()}");
            }
            else if (optiune == 2)
            {
                Console.Write("Scrie numele produsului: ");
                string numeProdus = Console.ReadLine();

                bool gasit = false;

                for (int i = 0; i < Program.Lista.DeCumparat.Count; i++)
                {
                    if (Program.Lista.DeCumparat[i].Denumire.ToLower() == numeProdus.ToLower())
                    {
                        Produs produs = Program.Lista.DeCumparat[i];
                        Console.WriteLine($"Produsul gasit in lista de cumparat este: {produs.GetData()}");
                        gasit = true;
                        break;
                    }
                }

                if (!gasit)
                {
                    for (int i = 0; i < Program.Lista.Achizitionate.Count; i++)
                    {
                        if (Program.Lista.Achizitionate[i].Denumire.ToLower() == numeProdus.ToLower())
                        {
                            Produs produs = Program.Lista.Achizitionate[i];
                            Console.WriteLine($"Produsul gasit in lista de produse achizitionate este: {produs.GetData()}");
                            gasit = true;
                            break;
                        }
                    }
                }

                if (!gasit)
                {
                    Console.WriteLine("Produsul nu a fost gasit.");
                }
            }

            Console.WriteLine("\nApasa orice tasta pentru a reveni la meniul principal...");
            Console.ReadKey();
        }
    }
}
namespace App16
{
    internal class Catalog
    {
        public List<Vehicle> Vehicles;
        public Catalog()
        {
            Vehicles = new List<Vehicle>();
        }
        public void SortByPrice(bool orderByDescending)
        {
            if (orderByDescending == false)
            {
                Vehicles = Vehicles.OrderBy(x => x.Price).ToList();
            }
            else
            {
                Vehicles = Vehicles.OrderByDescending(x => x.Price).ToList();
            }

        }
        public void SortByYear(bool orderByDescending)
        {
            if (orderByDescending == false)
            {
                Vehicles = Vehicles.OrderBy(x => x.Year).ToList();
            }
            else
            {
                Vehicles = Vehicles.OrderByDescending(x => x.Year).ToList();
            }
        }
        public void SortByKm(bool orderByDescending)
        {
            if (orderByDescending == false)
            {
                Vehicles = Vehicles.OrderBy(x => x.Km).ToList();
            }
            else
            {
                Vehicles = Vehicles.OrderByDescending(x => x.Km).ToList();
            }
        }
        public void SortByBrand(bool orderByDescending)
        {
            if (orderByDescending == false)
            {
                Vehicles = Vehicles.OrderBy(x => x.Brand).ToList();
            }
            else
            {
                Vehicles = Vehicles.OrderByDescending(x => x.Brand).ToList();
            }
        }

        public List<Vehicle> FilterByBrand(string brand)
        {
            return Vehicles.FindAll(x=> x.Brand.ToLower() == brand.ToLower());
        }
        public void ShowAllVehicles()
        {
            Console.WriteLine("In catalogul nostru avem urmatoarele masini:\n");
            for (int i = 0; i < Vehicles.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + Vehicles[i].GetData());
            }
        }
        public static void ShowAllVehiclesFromCollection(List<Vehicle> collection)
        {
            Console.WriteLine("In catalogul nostru avem urmatoarele masini:\n");
            for (int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + collection[i].GetData());
            }
        }
    }
}

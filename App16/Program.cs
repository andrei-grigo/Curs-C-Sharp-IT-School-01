using App16;
using ITSchool.AppUtilities;

namespace App16 {
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application16 app = new Application16();
            app.Launch();
        }
    }

    public class Application16 : ApplicationBase
    {
        public Application16()
        {
            Cerinta = "Sa se realizeze un catalog";
        }
        public override void Launch()
        {
            Catalog catalog = new Catalog();
            catalog.Vehicles.Add(new Vehicle("Chevrolet", "Aveo", 2010, 153000, 1700));
            catalog.Vehicles.Add(new Vehicle("Volkswagen", "Polo", 2011, 120000, 3000));
            catalog.Vehicles.Add(new Vehicle("Renault", "Megane", 2012, 175000, 5000));
            catalog.Vehicles.Add(new Vehicle("Opel", "Corsa", 2004, 180000, 3200));
            catalog.Vehicles.Add(new Vehicle("Mercedes", "GLA", 2020, 20000, 38280));
            catalog.Vehicles.Add(new Vehicle("Seat", "Leon Mk4", 2024, 100, 27000));
            catalog.Vehicles.Add(new Vehicle("seat", "Leon", 2006, 200000, 3000));
            catalog.Vehicles.Add(new Vehicle("Opel", "Zafira", 1999, 245000, 500));
            catalog.Vehicles.Add(new Vehicle("Chevrolet", "Camaro", 2020, 60000, 35000));

            catalog.ShowAllVehicles();

            catalog.SortByPrice(true);
            Console.WriteLine();

            List<Vehicle> filteredList = catalog.FilterByBrand("SeaT");

            Console.WriteLine();

            Catalog.ShowAllVehiclesFromCollection(filteredList);
        }
    }
}
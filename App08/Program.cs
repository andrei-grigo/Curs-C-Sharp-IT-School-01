namespace App08
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application08 app = new Application08();

            //aficam cerinta
            Console.WriteLine(app.Cerinta);

            //lansam aplicatia
            app.Launch();
        }
    }
}
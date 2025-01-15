namespace App14
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application14 app = new Application14();

            //aficam cerinta
            Console.WriteLine(app.Cerinta);

            //lansam aplicatia
            app.Launch();
        }
    }
}
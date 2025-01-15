namespace App04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application04 app = new Application04();

            //aficam cerinta
            Console.WriteLine(app.Cerinta);

            //lansam aplicatia
            app.Launch();
        }
    }
}
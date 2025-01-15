namespace App07
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application07 app = new Application07();

            //aficam cerinta
            Console.WriteLine(app.Cerinta);

            //lansam aplicatia
            app.Launch();
        }
    }
}
namespace App09
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application09 app = new Application09();

            //aficam cerinta
            Console.WriteLine(app.Cerinta);

            //lansam aplicatia
            app.Launch();
        }
    }
}
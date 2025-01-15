namespace App05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application05 app = new Application05();

            //aficam cerinta
            Console.WriteLine(app.Cerinta);

            //lansam aplicatia
            app.Launch();
        }
    }
}
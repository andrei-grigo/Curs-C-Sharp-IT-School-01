namespace App13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application13 app = new Application13();

            //aficam cerinta
            Console.WriteLine(app.Cerinta);

            //lansam aplicatia
            app.Launch();
        }
    }
}
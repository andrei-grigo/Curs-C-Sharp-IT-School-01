namespace App12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application12 app = new Application12();

            //aficam cerinta
            Console.WriteLine(app.Cerinta);

            //lansam aplicatia
            app.Launch();
        }
    }
}
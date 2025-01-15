namespace App03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application03 app = new Application03();

            //aficam cerinta
            Console.WriteLine(app.Cerinta);

            //lansam aplicatia
            app.Launch();
        }
    }
}
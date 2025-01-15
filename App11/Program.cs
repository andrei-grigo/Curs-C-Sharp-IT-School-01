namespace App11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application11 app = new Application11();

            //aficam cerinta
            Console.WriteLine(app.Cerinta);

            //lansam aplicatia
            app.Launch();
        }
    }
}
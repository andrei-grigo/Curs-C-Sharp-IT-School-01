namespace App02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application02 app = new Application02();

            //aficam cerinta
            Console.WriteLine(app.Cerinta);

            //lansam aplicatia
            app.Launch();
        }
    }
}
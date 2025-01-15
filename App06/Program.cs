namespace App06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application06 app = new Application06();

            //aficam cerinta
            Console.WriteLine(app.Cerinta);

            //lansam aplicatia
            app.Launch();
        }
    }
}
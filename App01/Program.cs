namespace App01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application01 app = new Application01();

            //aficam cerinta
            Console.WriteLine(app.Cerinta);

            //lansam aplicatia
            app.Launch();
        }
    }
}
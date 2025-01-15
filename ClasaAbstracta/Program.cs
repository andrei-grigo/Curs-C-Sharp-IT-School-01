internal class Program
{
    private static void Main(string[] args)
    {
        Cat pisica1 = new Cat("Pufu");
        Cat pisica2 = new Cat("Miau");
        Animal pisica3 = new Cat("Zazzy");

        Console.WriteLine(pisica3.Name + " are " + pisica3.GetFeetCount() + " picioare.");
    }
}

abstract class Animal
{
    public string Name;
    public Animal(string name)
    {
        Name = name;
    }
    public abstract int GetFeetCount();
}

class Cat : Animal
{
    public Cat(string name) : base(name)
    {

    }
    public override int GetFeetCount()
    {
        return 4;
    }
}
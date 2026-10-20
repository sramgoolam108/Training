namespace Training;

public class Person
{
    public string Name { get; set; }
    public string surname { get; set; }

    public void introduce()
    {
        System.Console.WriteLine($"Hello, my name is {Name} {surname}");
    }
}

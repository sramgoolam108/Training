namespace Training;
using Fundamentals.Calculator;

class Program
{
    static void Main (string[] args)
    {
        var number =1;
        Increment(number);
        Console.WriteLine(number); //value of number does not change, it only changes a copy of it.

        var Person = new Person()
        {
            Age = 20
        };
        Increment(Person);
        Console.WriteLine(Person.Age); //value of person changes, because we are passing a reference to the object, not a copy of it.
        
    }

    public static void Increment(int number)
    {
        number++;
    }

    public static void Increment(Person person)
    {
        person.Age++;
    }
}

namespace Training;
using Fundamentals.Calculator;

class Program
{
    static void Main (string[] args)
    {
        Person person = new Person();
        person.Name = "John";
        person.surname = "Doe";
        person.introduce();

        Calculator calculator = new Calculator();
        System.Console.WriteLine($"The sum of 5 and 3 is: {calculator.Add(5, 3)}");
    }
}



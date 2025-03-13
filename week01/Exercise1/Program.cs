using System;

class Program
{
    static void Main(string[] args)
    {
        //LN - Assking the user for their first and last name
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        //LN - Displaying the user's names using string interpolation
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}!");

    }
}
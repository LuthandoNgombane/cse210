using System;

class Program
{
    static void Main(string[] args)
    {
       
        //LN : Define display welcome function
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        //LN : Define prompt user name function
        string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            return Console.ReadLine();
        }

        //LN : Define prompt user number function
        int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        //LN : Define square number function
        int SquareNumber(int number)
        {
            return number * number;
        }

        //LN : Define display result function
        void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }

        //LN : Call the functions
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);

    }
}
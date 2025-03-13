using System;

class Program
{
    static void Main(string[] args)
    {
        
        //LN : Ask the user for their grade percentage
        Console.WriteLine("Enter your grade percentage: ");
        int grade = Convert.ToInt32(Console.ReadLine());

        //LN : Write a series of if, else if, else statements to print out the appropriate letter grade
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //LN : Add a separate if statement to determine if the user passed the course
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course with a grade of " + letter);
        }
        else
        {
            Console.WriteLine("You did not pass the course. Better luck next time!");
        }

        //LN : Have a single print statement that prints the letter grade once
        Console.WriteLine("Your letter grade is: " + letter);

        //LN : Add to your code the ability to include a "+" or "-" next to the letter grade
        string sign = "";

        //LN : Use modulus to find remainder when dividing by 10
        if (grade % 10 >= 7)
        {
            sign = "+";
        }
        else if (grade % 10 < 3)
        {
            sign = "-";
        }

        //LN : Add additional logic to handle exceptional cases of A+, F+, or F-
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        else if (letter == "F" && (sign == "+" || sign == "-"))
        {
            sign = "";
        }

        //LN : Display both the grade letter and the sign in one print statement
        Console.WriteLine("Your letter grade is: " + letter + sign);

    }
}
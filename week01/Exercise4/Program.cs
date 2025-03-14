
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //LN : Declare variables to store the numbers, sum, count, max, min, smallest positive, and average.
        int number = 0;
        int sum = 0;
        int count = 0;
        int max = 0;
        int min = 0;
        int smallestPositive = 0;
        double average = 0;
        bool firstPositive = true;
        bool firstNumber = true;
        string input = "";
        List<string> numbers = new List<string>();

        //LN : Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            input = Console.ReadLine();
            number = Convert.ToInt32(input);

            if (number != 0)
            {
                //LN : Add the number to the list
                numbers.Add(input);
                sum += number;
                count++;

                //LN : Check if the number is the first number entered
                if (firstNumber)
                {
                    max = number;
                    min = number;
                    firstNumber = false;
                }

                //LN : Check if the number is the largest number entered
                if (number > max)
                {
                    max = number;
                }

                //LN : Check if the number is the smallest positive number entered
                if (number > 0)
                {
                    if (firstPositive)
                    {
                        smallestPositive = number;
                        firstPositive = false;
                    }
                    if (number < smallestPositive)
                    {
                        smallestPositive = number;
                    }
                }

                //LN : Check if the number is the smallest number entered
                if (number < min)
                {
                    min = number;
                }
            }
        } while (number != 0);

        //LN : Compute the average of the numbers in the list.
        average = (double)sum / count;

        //LN : Display the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        //LN : Check if there is a smallest positive number
        if (smallestPositive != 0)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
    }
}

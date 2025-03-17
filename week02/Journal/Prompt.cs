// LN - Includes the System namespace, which provides basic classes like Random and Console
using System;

// LN - Includes the System.Collections.Generic namespace, which provides the List<T> class for dynamic arrays
using System.Collections.Generic;

// LN - Declares a public class named Prompt to manage random writing prompts
public class Prompt
{
    // LN - Declares a private List<string> variable _prompts to store a collection of prompt strings; List<string> is a dynamic, resizable array of strings
    private List<string> _prompts;

    // LN - Declares a private Random variable _random to generate random numbers; Random is a class for random number generation
    private Random _random;

    // LN - Defines the constructor for Prompt class, called when a new Prompt object is created; public means it’s accessible outside the class
    public Prompt()
    {
        // LN - Initializes _random as a new Random object to generate random numbers for selecting prompts
        _random = new Random();

        // LN - Initializes _prompts as a new List<string> and populates it with prompt strings; List<string> holds a sequence of strings
        _prompts = new List<string>
        {
            // LN - Adds a string literal to the _prompts list; string is a data type for text
            "Who was the most interesting person I interacted with today?",
            // LN - Adds another string to the _prompts list
            "What was the best part of my day?",
            // LN - Adds another string to the _prompts list
            "How did I see the hand of the Lord in my life today?",
            // LN - Adds another string to the _prompts list
            "What was the strongest emotion I felt today?",
            // LN - Adds another string to the _prompts list
            "If I had one thing I could do over today, what would it be?",
            // LN - Adds another string to the _prompts list (extra for creativity)
            "What’s something I learned today that surprised me?"
        };
    }

    // LN - Defines a public method GetRandomPrompt that returns a random string from _prompts; string is the return type
    public string GetRandomPrompt()
    {
        // LN - Declares an int variable index and assigns it a random number from 0 to _prompts.Count-1; int is a 32-bit integer, Next(int) generates a random number up to the specified max
        int index = _random.Next(_prompts.Count);

        // LN - Returns the string at the random index from _prompts; _prompts[index] accesses an element in the List<string> by its position
        return _prompts[index];
    }
}
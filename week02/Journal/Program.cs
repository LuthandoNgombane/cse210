// LN - Includes the System namespace, which provides classes like Console and DateTime
using System;

// LN - Declares a class named Program as the entry point of the application; no public modifier defaults to internal
class Program
{
    // LN - Defines the Main method, the starting point of the program; static means it’s called without an instance, string[] args holds command-line arguments
    static void Main(string[] args)
    {
        // LN - Declares a Journal variable and initializes it with a new Journal object; Journal manages the entries
        Journal journal = new Journal();

        // LN - Declares a Prompt variable and initializes it with a new Prompt object; Prompt generates random prompts
        Prompt promptGenerator = new Prompt();

        // LN - Declares a bool variable running to control the menu loop; bool is a true/false data type
        bool running = true;

        // LN - Writes a welcome message to the console; WriteLine outputs text with a newline
        Console.WriteLine("Welcome to Your Journal Program!");

        // LN - Writes an additional message for user experience
        Console.WriteLine("Keep your memories alive with daily prompts.\n");

        // LN - Starts a while loop that runs as long as running is true; while repeats code based on a condition
        while (running)
        {
            // LN - Writes a blank line for readability
            Console.WriteLine("\nMenu:");

            // LN - Writes the first menu option
            Console.WriteLine("1. Write a new entry");

            // LN - Writes the second menu option
            Console.WriteLine("2. Display the journal");

            // LN - Writes the third menu option
            Console.WriteLine("3. Save the journal to a file");

            // LN - Writes the fourth menu option
            Console.WriteLine("4. Load the journal from a file");

            // LN - Writes the fifth menu option
            Console.WriteLine("5. Quit");

            // LN - Prompts the user to choose an option; Write outputs text without a newline
            Console.Write("Choose an option (1-5): ");

            // LN - Declares a string variable choice and reads user input; ReadLine returns a string from console input
            string choice = Console.ReadLine();

            // LN - Starts a switch statement to handle the user’s choice; switch selects code blocks based on a value
            switch (choice)
            {
                // LN - Case for option 1: Write a new entry
                case "1":
                    // LN - Declares a string variable date and gets the current date; DateTime.Now is the current date/time, ToShortDateString returns it as a string (e.g., "3/17/2025")
                    string date = DateTime.Now.ToShortDateString();

                    // LN - Declares a string variable prompt and gets a random prompt; GetRandomPrompt returns a string
                    string prompt = promptGenerator.GetRandomPrompt();

                    // LN - Writes the date to the console
                    Console.WriteLine($"\nDate: {date}");

                    // LN - Writes the prompt to the console
                    Console.WriteLine($"Prompt: {prompt}");

                    // LN - Prompts the user for a response
                    Console.Write("Your response: ");

                    // LN - Declares a string variable response and reads user input
                    string response = Console.ReadLine();

                    // LN - Adds a new Entry to the journal; new Entry creates an object, AddEntry stores it
                    journal.AddEntry(new Entry(date, prompt, response));

                    // LN - Writes a confirmation message
                    Console.WriteLine("Entry added!");
                    break;

                // LN - Case for option 2: Display the journal
                case "2":
                    // LN - Calls DisplayEntries to show all entries
                    journal.DisplayEntries();
                    break;

                // LN - Case for option 3: Save the journal
                case "3":
                    // LN - Prompts the user for a filename
                    Console.Write("Enter filename to save: ");

                    // LN - Declares a string variable saveFile and reads user input
                    string saveFile = Console.ReadLine();

                    // LN - Saves the journal to the specified file
                    journal.SaveToFile(saveFile);
                    break;

                // LN - Case for option 4: Load the journal
                case "4":
                    // LN - Prompts the user for a filename
                    Console.Write("Enter filename to load: ");

                    // LN - Declares a string variable loadFile and reads user input
                    string loadFile = Console.ReadLine();

                    // LN - Loads the journal from the specified file
                    journal.LoadFromFile(loadFile);
                    break;

                // LN - Case for option 5: Quit the program
                case "5":
                    // LN - Sets running to false to exit the loop
                    running = false;

                    // LN - Writes a goodbye message
                    Console.WriteLine("Goodbye!");
                    break;

                // LN - Default case for invalid input
                default:
                    // LN - Writes an error message for invalid choices
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
// Program.cs
class Program
{
    
    //LN - This is the main class of the Scripture Memorizer program.
    static void Main(string[] args)
    {

        //LN - It creates an instance of the ScriptureLibrary class, retrieves a random scripture, and starts the memorization session.
        ScriptureLibrary library = new ScriptureLibrary("scriptures.txt");

        //LN - Get a random scripture from the library.
        //LN - This scripture will be used for the memorization session.
        Scripture scripture = library.GetRandomScripture();
        
        //LN - Start the memorization session with the selected scripture.

        //LN - The session continues until the user chooses to quit or all words are hidden.
        //LN - The session displays the scripture text and allows the user to hide random words.
        while (true)
        {

            //LN - Clear the console and display the scripture text.
            Console.Clear();

            //LN - The GetDisplayText method returns the scripture reference and the current state of the words (hidden or visible).
            Console.WriteLine(scripture.GetDisplayText());

            //LN - Display instructions for the user.
            //LN - The user can press Enter to hide random words or type 'quit' to exit the program.
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            
            //LN - Read the user's input from the console.
            //LN - If the input is 'quit', break the loop and end the program.
            //LN - If the input is not 'quit', hide random words in the scripture.
            //LN - The HideRandomWords method hides a specified number of random words in the scripture text.
            string input = Console.ReadLine();

            //LN - Check if the user wants to quit the program.
            //LN - If the input is 'quit', break the loop and end the program.
            if (input?.ToLower() == "quit") break;
            
            //LN - If the user presses Enter, hide random words in the scripture.
            //LN - The HideRandomWords method hides a specified number of random words in the scripture text.
            if (!scripture.AllWordsHidden)
            {
                //LN - Hide a specified number of random words in the scripture text.
                scripture.HideRandomWords();
            }
            else
            {

                //LN - If all words are hidden, clear the console and display a message indicating that the program is ending.
                //LN - This prevents the user from hiding words when all words are already hidden.
                Console.Clear();

                //LN - Display the scripture text with all words hidden.
                Console.WriteLine(scripture.GetDisplayText());

                //LN - Display a message indicating that all words are hidden and the program is ending.
                Console.WriteLine("\nAll words hidden! Program ending...");

                //LN - Wait for 2 seconds before exiting the program.
                Thread.Sleep(2000);

                //LN - Break the loop to end the program.
                break;
            }
        }
    }
}
















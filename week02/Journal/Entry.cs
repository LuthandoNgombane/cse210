// LN - Includes the System namespace, which provides basic classes like Console for output
using System;

// LN - Declares a public class named Entry to represent a single journal entry
public class Entry
{
    // LN - Declares a private string variable _date to store the date of the entry; string is a data type for text
    private string _date;

    // LN - Declares a private string variable _prompt to store the writing prompt; private restricts access to within the class
    private string _prompt;

    // LN - Declares a private string variable _response to store the user's response
    private string _response;

    // LN - Defines a public constructor for Entry, taking three string parameters to initialize the object; public allows creation from outside
    public Entry(string date, string prompt, string response)
    {
        // LN - Assigns the date parameter to the private _date field; this sets the entry's date
        _date = date;

        // LN - Assigns the prompt parameter to the private _prompt field; this sets the entry's prompt
        _prompt = prompt;

        // LN - Assigns the response parameter to the private _response field; this sets the entry's response
        _response = response;
    }

    // LN - Defines a public method GetDisplayText that returns a formatted string; string is the return type for text
    public string GetDisplayText()
    {
        // LN - Returns a formatted string combining _date, _prompt, and _response with newlines (\n); $ is string interpolation
        return $"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}\n";
    }

    // LN - Defines a public method GetSaveText that returns a string for file saving; uses | as a separator
    public string GetSaveText()
    {
        // LN - Returns a string with _date, _prompt, and _response separated by |; this format is used for saving to a file
        return $"{_date}|{_prompt}|{_response}";
    }

    // LN - Defines a public static method FromSaveText to create an Entry from a saved string; static means it’s called on the class, not an instance
    public static Entry FromSaveText(string line)
    {
        // LN - Declares a string array parts and splits the input line at |; Split(char) divides a string into an array based on a separator
        string[] parts = line.Split('|');

        // LN - Returns a new Entry object using the split parts; parts[0] is date, parts[1] is prompt, parts[2] is response
        return new Entry(parts[0], parts[1], parts[2]);
    }
}
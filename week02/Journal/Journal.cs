// LN - Includes the System namespace, which provides basic classes like Console and File
using System;

// LN - Includes the System.Collections.Generic namespace, which provides the List<T> class for dynamic arrays
using System.Collections.Generic;

// LN - Includes the System.IO namespace, which provides classes like StreamWriter and File for file operations
using System.IO;

// LN - Declares a public class named Journal to manage a collection of entries
public class Journal
{
    // LN - Declares a private List<Entry> variable _entries to store Entry objects; List<Entry> is a dynamic list of Entry instances
    private List<Entry> _entries;

    // LN - Defines a public constructor for Journal, initializing the object
    public Journal()
    {
        // LN - Initializes _entries as a new List<Entry> to hold journal entries; new creates a new instance
        _entries = new List<Entry>();
    }

    // LN - Defines a public method AddEntry to add an Entry to the journal; void means it returns nothing
    public void AddEntry(Entry entry)
    {
        // LN - Adds the entry parameter to the _entries list; Add method appends an item to the List<Entry>
        _entries.Add(entry);
    }

    // LN - Defines a public method DisplayEntries to show all entries; void indicates no return value
    public void DisplayEntries()
    {
        // LN - Checks if _entries is empty; Count property returns the number of items in the list
        if (_entries.Count == 0)
        {
            // LN - Writes a message to the console if there are no entries; WriteLine outputs text with a newline
            Console.WriteLine("No entries to display.");
            
            // LN - Exits the method early if the list is empty; return stops execution here
            return;
        }

        // LN - Loops through each Entry in _entries; foreach iterates over a collection
        foreach (Entry entry in _entries)
        {
            // LN - Writes the entry’s display text to the console; GetDisplayText returns a formatted string
            Console.WriteLine(entry.GetDisplayText());
        }
    }

    // LN - Defines a public method SaveToFile to save entries to a file; takes a string parameter for the filename
    public void SaveToFile(string filename)
    {
        // LN - Creates a StreamWriter object in a using block to write to the file; using ensures the file is closed properly
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // LN - Loops through each Entry in _entries to write to the file
            foreach (Entry entry in _entries)
            {
                // LN - Writes the entry’s save text to the file with a newline; WriteLine adds text to the file
                outputFile.WriteLine(entry.GetSaveText());
            }
        }

        // LN - Writes a confirmation message to the console; $ allows embedding the filename in the string
        Console.WriteLine($"Journal saved to {filename}");
    }

    // LN - Defines a public method LoadFromFile to load entries from a file; takes a string parameter for the filename
    public void LoadFromFile(string filename)
    {
        // LN - Checks if the file exists; File.Exists returns true if the file is found
        if (!File.Exists(filename))
        {
            // LN - Writes an error message if the file doesn’t exist
            Console.WriteLine("File not found.");

            // LN - Exits the method if the file isn’t found
            return;
        }

        // LN - Clears the current _entries list; Clear removes all items from the List<Entry>
        _entries.Clear();

        // LN - Reads all lines from the file into a string array; ReadAllLines returns an array of strings, one per line
        string[] lines = File.ReadAllLines(filename);

        // LN - Loops through each line in the file
        foreach (string line in lines)
        {
            // LN - Checks if the line is not empty or whitespace; IsNullOrWhiteSpace returns true for null or blank strings
            if (!string.IsNullOrWhiteSpace(line))
            {
                // LN - Adds a new Entry to _entries by parsing the line; FromSaveText creates an Entry from a string
                _entries.Add(Entry.FromSaveText(line));
            }
        }

        // LN - Writes a confirmation message to the console
        Console.WriteLine($"Journal loaded from {filename}");
    }
}
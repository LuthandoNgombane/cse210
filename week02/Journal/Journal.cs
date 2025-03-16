//LN - Journal class manages a collection of journal entries
using System;
using System.Collections.Generic;

public class Journal
{
    //LN - List to store journal entries
    private List<Entry> _entries;

    //LN - Constructor initializes the entries list
    public Journal()
    {
        _entries = new List<Entry>();
    }

    //LN - Method to add an entry to the journal
    public void AddEntry(Entry entry)
    {
        //LN - Stub: Add entry to the list (to be implemented later)
    }

    //LN - Method to display all journal entries
    public void DisplayEntries()
    {
        //LN - Stub: Display all entries (to be implemented later)
    }

    //LN - Method to save journal entries to a file
    public void SaveToFile(string filename)
    {
        //LN - Stub: Save entries to a file (to be implemented later)
    }

    //LN - Method to load journal entries from a file
    public void LoadFromFile(string filename)
    {
        //LN - Stub: Load entries from a file (to be implemented later)
    }
}
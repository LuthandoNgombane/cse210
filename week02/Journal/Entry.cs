//LN - Entry class represents a single journal entry
using System;

public class Entry
{
    //LN - Attributes to store date, prompt, and response
    private string _date;
    private string _prompt;
    private string _response;

    //LN - Constructor initializes entry attributes
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    //LN - Method to get formatted display text for an entry
    public string GetDisplayText()
    {
        //LN - Placeholder return value
        return ""; 
    }
}
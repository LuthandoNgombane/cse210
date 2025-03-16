//LN - Prompt class manages journal prompts
using System;
using System.Collections.Generic;

public class Prompt
{
    //LN - List to store predefined prompts
    private List<string> _prompts;

    //LN - Constructor initializes the list with default prompts
    public Prompt()
    {
        _prompts = new List<string>
        {
            "What was the best part of your day?",
            "Who did you talk to today?",
            "What did you learn today?"
        };
    }

    //LN - Method to return a random prompt
    public string GetRandomPrompt()
    {
        return ""; //LN - Placeholder return value
    }
}
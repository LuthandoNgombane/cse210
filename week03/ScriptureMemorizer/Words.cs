// LN - This class represents a word in the scripture memorization game.
// LN - It contains the text of the word and a flag indicating whether it is hidden or not.
public class Word
{

    //LN - The text of the word.
    private string _text;

    //LN - The flag indicating whether the word is hidden or not.
    private bool _isHidden;

    //LN - Constructor that initializes the word with the given text.
    //LN - The word is initially not hidden.
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //LN - Property to get the text of the word.
    public bool IsHidden => _isHidden;

    //LN - Method to hide the word.
    //LN - This method sets the _isHidden flag to true, indicating that the word is hidden.
    public void Hide() => _isHidden = true;

    //LN - Method to get the display text of the word.
    //LN - If the word is hidden, it returns a string of underscores with the same length as the word. Using Ternary operator to check if the word is hidden or not.
    //LN - If the word is not hidden, it returns the original text of the word.
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
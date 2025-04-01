//LN - This class represents a reference to a scripture passage.
//LN - It contains the book, chapter, start verse, and optional end verse of the scripture.
public class Reference
{

    //LN - The book of the scripture reference.
    private string _book;
    //LN - The chapter of the scripture reference.
    private int _chapter;
    //LN - The starting verse of the scripture reference.
    private int _startVerse;

    //LN - The optional ending verse of the scripture reference.
    //LN - This is nullable to indicate that it may not be present (e.g., for a single verse reference).
    private int? _endVerse;

    //LN - Constructor that initializes the reference with the given book, chapter, and start verse.
    public Reference(string book, int chapter, int verse) 
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = null;
    }

    //LN - Constructor that initializes the reference with the given book, chapter, start verse, and end verse.
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    //LN - Property to get the book of the scripture reference.
    public string GetDisplayText()
    {
        //LN - This method returns a string representation of the scripture reference.
        //LN - It includes the book, chapter, and verse(s).
        return _endVerse.HasValue 
            ? $"{_book} {_chapter}:{_startVerse}-{_endVerse}"
            : $"{_book} {_chapter}:{_startVerse}";
    }
}
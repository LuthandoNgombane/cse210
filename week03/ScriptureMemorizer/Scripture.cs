//LN - This class represents a scripture passage in the scripture memorization game.
//LN - It contains a reference to the scripture and a list of words in the scripture text.
public class Scripture
{

    //LN - The reference to the scripture passage.
    private Reference _reference;

    //LN - The list of words in the scripture text.
    //LN - This is a list of Word objects, each representing a word in the scripture text.
    private List<Word> _words;

    //LN - Constructor that initializes the scripture with the given reference and text.
    //LN - The text is split into words, and each word is stored as a Word object in the _words list.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        //LN - Split the text into words and create Word objects for each word.
        //LN - The words are stored in the _words list.
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    //LN - Property to get the reference of the scripture.
    //LN - This property returns the Reference object representing the scripture reference.
    public bool AllWordsHidden => _words.All(w => w.IsHidden);
    
    //LN - Property to get the list of words in the scripture.
    //LN - This property returns the list of Word objects representing the words in the scripture text.
    public void HideRandomWords(int count = 3)
    {

        //LN - This method hides a specified number of random words in the scripture text.
        //LN - The count parameter specifies the number of words to hide.
        var visibleWords = _words.Where(w => !w.IsHidden).ToList();

        //LN - If there are no visible words, return without hiding any words.
        //LN - This prevents an error when trying to hide words if all words are already hidden.
        if (visibleWords.Count == 0) return;

        //LN - Limit the count to the number of visible words to avoid errors.
        //LN - This ensures that we don't try to hide more words than are available.
        count = Math.Min(count, visibleWords.Count);

        //LN - Randomly select words to hide.
        var random = new Random();

        //LN - Loop through the specified number of times to hide words.
        //LN - For each iteration, a random index is selected from the visible words list.
        for (int i = 0; i < count; i++)
        {
            //LN - Randomly select an index from the visible words list.
            //LN - Hide the word at that index and remove it from the visible words list.
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            //LN - Remove the hidden word from the visible words list to avoid hiding it again.
            //LN - This ensures that we only hide words that are not already hidden.
            visibleWords.RemoveAt(index);
        }
    }

    //LN - Method to get the display text of the scripture.
    //LN - This method returns a string representation of the scripture reference and the words in the text.
    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}\n{string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }
}
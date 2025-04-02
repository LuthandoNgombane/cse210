//LN - This class represents a comment on a YouTube video, including the commenter's name and the text of the comment.
//LN - It demonstrates abstraction by encapsulating the details of the comment and its display format.
//LN - The class also uses encapsulation by having private fields and public methods to access them.

public class Comment
{

    //LN - These are the private fields for the Comment class.
    //LN - They store the commenter's name and the text of the comment.
    private string _commenterName;
    private string _text;


    //LN - This is the constructor for the Comment class.
    //LN - It initializes the commenter's name and the text of the comment.
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    //LN - These are the public methods for the Comment class.
    //LN - They allow access to the private fields and provide functionality to get the commenter's name, text, and display format.
    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetText()
    {
        return _text;
    }

    public string GetDisplayText()
    {
        return $"  - {_commenterName}: {_text}";
    }
}
//LN - This class represents a video on YouTube, including its title, author, length, and comments.
//LN - It displays the process of abstraction by encapsulating the details of the video and its comments.
//LN - The class also demonstrates encapsulation by using private fields and public methods to access them.

public class Video
{

    //LN - These are the private fields for the Video class.
    //LN - They store the title, author, length in seconds, and a list of comments.
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;


    //LN - This is the constructor for the Video class.
    //LN - It initializes the title, author, length, and creates an empty list of comments.
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    //LN - These are the public methods for the Video class.
    //LN - They allow access to the private fields and provide functionality to add comments and get the number of comments.
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetDisplayText()
    {
        string display = $"Title: {_title}\n" +
                        $"Author: {_author}\n" +
                        $"Length: {_lengthInSeconds} seconds\n" +
                        $"Number of Comments: {GetNumberOfComments()}\n" +
                        "Comments:\n";
        foreach (Comment comment in _comments)
        {
            display += comment.GetDisplayText() + "\n";
        }
        return display;
    }
}
//LN - This file contains the ScriptureLibrary class, which is responsible for loading and managing a collection of scriptures.
public class ScriptureLibrary
{

    //LN - This field stores a list of Scripture objects.
    private List<Scripture> _scriptures;

    //LN - This field is used to generate random numbers.
    private Random _random;

    //LN - Constructor that initializes the scripture library and loads scriptures from a file.
    //LN - The file path is passed as a parameter to the constructor.
    public ScriptureLibrary(string filePath)
    {
        //LN - Initialize the list of scriptures and the random number generator.
        //LN - The scriptures are loaded from the specified file path.
        _scriptures = new List<Scripture>();

        //LN - Initialize the random number generator.
        //LN - This is used to select random scriptures from the list.
        _random = new Random();

        //LN - Load scriptures from the specified file path.
        //LN - The file is expected to contain pairs of lines: the first line is the reference, and the second line is the text.
        LoadScriptures(filePath);
    }

    //LN - This method loads scriptures from a text file.
    private void LoadScriptures(string filePath)
    {

        //LN - The file is expected to contain pairs of lines: the first line is the reference, and the second line is the text.
        //LN - The reference line is split into parts to create a Reference object.
        try
        {

            //LN - Read all lines from the file and process them in pairs.
            //LN - The first line contains the reference, and the second line contains the text.
            var lines = File.ReadAllLines(filePath);

            //LN - Ensure that the number of lines is even.
            for (int i = 0; i < lines.Length; i += 2)
            {

                //LN - Split the reference line into parts.
                //LN - The first part is the book, the second part is the chapter, and the third part is the verse(s).
                string[] refParts = lines[i].Split(' ');

                //LN - Create a Reference object based on the parts.
                Reference reference;

                //LN - Check if the reference contains a range of verses (e.g., "3-5").
                //LN - If it does, create a Reference object with start and end verses.
                //LN - Otherwise, create a Reference object with a single verse.
                if (refParts[2].Contains("-"))
                {

                    //LN - Split the verse part to get the start and end verses.
                    //LN - Create a new Reference object with the book, chapter, start verse, and end verse.
                    string[] verses = refParts[2].Split('-');

                    //LN - Check if the verse part contains a range of verses (e.g., "3-5").
                    //LN - If it does, create a Reference object with start and end verses.
                    reference = new Reference(refParts[0], int.Parse(refParts[1]), 
                        int.Parse(verses[0]), int.Parse(verses[1]));
                }
                else
                {

                    //LN - Create a new Reference object with the book, chapter, and verse.
                    //LN - If it does not contain a range, create a Reference object with a single verse.
                    reference = new Reference(refParts[0], int.Parse(refParts[1]), 
                        int.Parse(refParts[2]));
                }


                //LN - Create a new Scripture object with the reference and text.
                //LN - Add the Scripture object to the list of scriptures.
                _scriptures.Add(new Scripture(reference, lines[i + 1]));
            }
        }

        //LN - Handle any exceptions that occur during file reading or processing.
        //LN - Print an error message to the console.
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading scriptures: {ex.Message}");
        }
    }

    //LN - This method returns a random scripture from the list of scriptures.
    //LN - It uses the Random object to select a random index from the list.
    //LN - The selected scripture is returned as a Scripture object.
    public Scripture GetRandomScripture()
    {
        return _scriptures[_random.Next(_scriptures.Count)];
    }
}
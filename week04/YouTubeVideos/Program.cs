using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //LN - This is the main entry point of the program.
        //LN - It creates a list of videos and adds some sample videos with comments to it.
        List<Video> videos = new List<Video>();

        //LN - The following lines create instances of the Video class and add comments to them.
        //LN - Each video has a title, author, length in seconds, and a list of comments.

        //LN - Video 1       
        Video video1 = new Video("Learning C# Basics", "CodeMaster", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Can you cover more advanced topics?"));
        videos.Add(video1);

        //LN - Video 2
        Video video2 = new Video("How to Cook Pasta", "ChefJohn", 300);
        video2.AddComment(new Comment("Diana", "This recipe worked perfectly!"));
        video2.AddComment(new Comment("Eve", "Love your videos!"));
        video2.AddComment(new Comment("Frank", "Can you make a video on desserts?"));
        video2.AddComment(new Comment("Grace", "So easy to follow!"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Yoga for Beginners", "FitGuru", 1200);
        video3.AddComment(new Comment("Hank", "I feel so relaxed after this!"));
        video3.AddComment(new Comment("Ivy", "Perfect for beginners!"));
        video3.AddComment(new Comment("Jack", "Thanks for the great session!"));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("DIY Home Decor", "CraftyKate", 450);
        video4.AddComment(new Comment("Kelly", "Love these ideas!"));
        video4.AddComment(new Comment("Liam", "Going to try this weekend!"));
        video4.AddComment(new Comment("Mia", "So creative!"));
        video4.AddComment(new Comment("Noah", "Can you do a video on outdoor decor?"));
        videos.Add(video4);

        //LN - Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine("------------------------");
        }
    }
}
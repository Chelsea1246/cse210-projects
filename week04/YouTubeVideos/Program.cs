using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("C# Basics Tutorial", "Alice Johnson", 600);
        Video video2 = new Video("Introduction to OOP", "Bob Smith", 720);
        Video video3 = new Video("Understanding Abstraction", "Carol Lee", 540);

        // Add comments to video1
        video1.AddComment(new Comment("John", "Great tutorial!"));
        video1.AddComment(new Comment("Emma", "Very helpful, thanks."));
        video1.AddComment(new Comment("Mike", "Can you explain more about loops?"));

        // Add comments to video2
        video2.AddComment(new Comment("Sara", "This makes OOP so clear!"));
        video2.AddComment(new Comment("Tom", "Awesome explanation."));
        video2.AddComment(new Comment("Lily", "Loved the examples."));

        // Add comments to video3
        video3.AddComment(new Comment("David", "Abstraction is tricky, thanks for this!"));
        video3.AddComment(new Comment("Sophia", "Excellent explanation."));
        video3.AddComment(new Comment("Chris", "Very clear, appreciate it."));

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display videos and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine(); // Blank line for spacing
        }
    }
}
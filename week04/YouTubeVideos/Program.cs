using System;
using System.Collections.Generic;
using System.Reflection;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");



        Video video1 = new Video();
        video1.Author = "Joseph Knight";
        video1._Length = 207;
        video1._title = "Human Tower";
        video1.AddComment("Alice", "Great video!");
        video1.AddComment("Bob", "Really informative.");
        video1.AddComment("Charlie", "Thanks for sharing!");

        Video video2 = new Video();
        video2.Author = "Derick";
        video2._Length = 267;
        video2._title = "Dumpster diving";
        video2.AddComment("Diana", "Fascinating content!");
        video2.AddComment("Eve", "Very well produced.");
        video2.AddComment("Frank", "Loved every minute of it!");

        Video video3 = new Video();
        video3.Author = "Mei Me Mi";
        video3._Length = 135;
        video3._title = "Sky Diving";
        video3.AddComment("George", "Incredible exploration!");
        video3.AddComment("Hannah", "Amazing discoveries!");
        video3.AddComment("Isaac", "So entertaining and educational!");

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"length (seconds): {video._Length}");
            Console.WriteLine($"Number of Comments: {video.commentNumber}");
            Console.WriteLine($"Comments:");
            foreach (Comment comment in video.comments)
            {
                Console.WriteLine($"- {comment._name}: {comment._comment}");
            }
            Console.WriteLine();

        }


    }
}

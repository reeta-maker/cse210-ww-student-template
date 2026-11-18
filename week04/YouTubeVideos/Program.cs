using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video();
        video1._title = "How to Cook Chilly Fried Rice";
        video1._author = "ChefReeta";
        video1._length = 320;

        Comment comment1 = new Comment();
        comment1._name = "Naveen";
        comment1._text = "This looks so good!";
        video1._comments.Add(comment1);

        Comment comment2 = new Comment();
        comment2._name = "Deddy";
        comment2._text = "I tried this for dinner and loved it.";
        video1._comments.Add(comment2);

        Comment comment3 = new Comment();
        comment3._name = "Hira";
        comment3._text = "Easy to follow recipe.";
        video1._comments.Add(comment3);

        videos.Add(video1);

        // Video 2
        Video video2 = new Video();
        video2._title = "Beginner Tabala Lesson 1";
        video2._author = "MusicWithMinu";
        video2._length = 540;

        Comment comment4 = new Comment();
        comment4._name = "Alex";
        comment4._text = "Finally learned my first Tabala beat!";
        video2._comments.Add(comment4);

        Comment comment5 = new Comment();
        comment5._name = "Navina";
        comment5._text = "Thank you for going slow.";
        video2._comments.Add(comment5);

        Comment comment6 = new Comment();
        comment6._name = "Kajol";
        comment6._text = "Best Tabala teacher on YouTube.";
        video2._comments.Add(comment6);

        videos.Add(video2);

        // Video 3
        Video video3 = new Video();
        video3._title = "Funny Pet Compilation";
        video3._author = "DailyPets";
        video3._length = 185;

        Comment comment7 = new Comment();
        comment7._name = "Robot";
        comment7._text = "The orange cat at 1:10 made me laugh.";
        video3._comments.Add(comment7);

        Comment comment8 = new Comment();
        comment8._name = "Pabitra";
        comment8._text = "I watch this whenever I feel stressed.";
        video3._comments.Add(comment8);

        Comment comment9 = new Comment();
        comment9._name = "Puskar";
        comment9._text = "So cute!";
        video3._comments.Add(comment9);

        videos.Add(video3);

        // Print everything out
        foreach (Video v in videos)
        {
            Console.WriteLine();
            Console.WriteLine($"Title: {v._title}");
            Console.WriteLine($"Author: {v._author}");
            Console.WriteLine($"Length: {v._length} seconds");
            Console.WriteLine($"Number of comments: {v.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment c in v._comments)
            {
                Console.WriteLine($"- {c._name}: {c._text}");
            }
        }
    }
}

using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Reveiwing Python", "Zahra", 580);
        video1._comments.Add(new Comment("Kim", "Thank you so much!"));
        video1._comments.Add(new Comment("Tani", "This was very helpful!"));
        video1._comments.Add(new Comment("Serena", "When will you do lessons on C#?"));
        videos.Add(video1);

        Video video2 = new Video("Cook with me", "Joe", 1280);
        video2._comments.Add(new Comment("Hawi", "Thank you so much, I cooked this for the first time today!"));
        video2._comments.Add(new Comment("Joy", "This was delicious!"));
        video2._comments.Add(new Comment("Sherlyne", "You should make a video about pasta next!"));
        videos.Add(video2);

        Video video3 = new Video("Travel Vlog", "Rashe", 2000);
        video3._comments.Add(new Comment("Amy", "Hope you get there safe!"));
        video3._comments.Add(new Comment("Shaleen", "Going to miss you!"));
        video3._comments.Add(new Comment("Mary", "The video quality is terrible."));
        videos.Add(video3);

        Video video4 = new Video("Day in my life", "Nicole", 1500);
        video4._comments.Add(new Comment("Austin", "Where do you get your skincare products from?"));
        video4._comments.Add(new Comment("Nadia", "How do you stay so productive all day?"));
        video4._comments.Add(new Comment("Kendra", "Workout routine please!!"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds.");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()} comments.");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"  {comment._name}: {comment._text}");
            }
            Console.WriteLine(); 
        }
    }
}

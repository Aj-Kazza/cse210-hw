using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // videos
        Video v1 = new Video("You won't believe this", "AYO the Man", 480);
        Video v2 = new Video("How to be STELTH", "Ninja101", 960);
        Video v3 = new Video("If Only [Official Music Video]", "Kir0", 180);

        // comments
        Comment c1 = new Comment("userman", "very helpful, 10/10");
        Comment c2 = new Comment("pomeranianrain", "how to downlaod mp4 version? pls");
        Comment c3 = new Comment("4567418", "how have I never known about this!?");
        Comment c4 = new Comment("breadislife", "2:15 am I the only one who noticed the car is upside down!?");
        Comment c5 = new Comment("john john", "good");
        Comment c6 = new Comment("Redstone Parkour Official", "It was a pleasure to have you over, love the video");
        Comment c7 = new Comment("baerumi9920", "i love this so much, i was so emotional");
        Comment c8 = new Comment("user90923415862", "ngl, pretty mid imo no cap fr fr");
        Comment c9 = new Comment("pomeranianrain", "how to downlaod mp3 version? pls");
        Comment c10 = new Comment("io_559vv", "who else is watching this in 2026?");
        
        v1.AddComment(c5);
        v1.AddComment(c2);
        v1.AddComment(c3);
        v1.AddComment(c8);

        v2.AddComment(c6);
        v2.AddComment(c4);
        v2.AddComment(c5);
        v2.AddComment(c10);

        v3.AddComment(c1);
        v3.AddComment(c9);
        v3.AddComment(c7);
        v3.AddComment(c5);

        List<Video> videos = [];
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video v in videos)
        {
            Console.WriteLine(v.GetDisplayText());
        }



        


    }
}
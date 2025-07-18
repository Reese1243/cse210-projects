using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        List<Comment> comments = new List<Comment>();

        Video video1 = new Video("DJmusicman", "How to use GarageBand", 1440);
        Video video2 = new Video("IronMan1204", "How to forge an iron rose", 2700);
        Video video3 = new Video("ProCode023", "C# tutorial 1 'hello world'", 720);

        Comment comment1 = new Comment("BillBillison", "Amazing video! keep up the good work!");
        Comment comment2 = new Comment("shellman2002", "This video was incredibly helpful!");
        Comment comment3 = new Comment("Bizbam302", "this is such a great tutorial! I was able to fix my issue and finish my project!");
        Comment comment4 = new Comment("GreebisPlinko928", "yellow? or green?");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        comments.Add(comment1);
        comments.Add(comment2);
        comments.Add(comment3);
        comments.Add(comment4);

        foreach (Video video in videos)
        {
            video.AddComment(comment1);
            video.AddComment(comment2);
            video.AddComment(comment3);
            video.AddComment(comment4);
        }

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }



    }
}
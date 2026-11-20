using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Understanding C# Classes and Objects", "CodeAcademy", 645);
        video1.AddComment(new Comment("Tinashe M.", "This made abstraction finally click for me!"));
        video1.AddComment(new Comment("Sarah K.", "Great pacing and clear examples."));
        video1.AddComment(new Comment("DevExplorer", "Could you do a follow-up on inheritance next?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Solar Inverter Setup Guide for Beginners", "OffGridTech", 1120);
        video2.AddComment(new Comment("Farai N.", "What gauge wire did you use for the battery bank?"));
        video2.AddComment(new Comment("Mark R.", "Super helpful walkthrough, saved me hours."));
        video2.AddComment(new Comment("Chiedza P.", "Subscribed! Very clean wiring layout."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Top 5 Football Tactical Drills", "PitchSide", 480);
        video3.AddComment(new Comment("Coach Tariro", "Used drill #2 with my U16 squad yesterday."));
        video3.AddComment(new Comment("Kuda B.", "The transition speed in the third drill is intense."));
        video3.AddComment(new Comment("Alex G.", "Simple setup with just cones, love it."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}
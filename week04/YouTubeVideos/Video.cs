/*
 * Name: Brighton Munezi
 * Student ID: 30112119
 * Course: CS210
 * Assignment: W04 Assignment: YouTube Video Program
 * Date: 11/20/2026
 * Description: A programme that tracks the placement of a company's products in YouTube videos
 */

using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}s");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine($"Comments: ");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}
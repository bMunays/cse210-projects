/*
 * Name: Brighton Munezi
 * Student ID: 30112119
 * Course: CS210
 * Assignment: W04 Assignment: YouTube Video Program
 * Date: 11/20/2026
 * Description: A programme that tracks the placement of a company's products in YouTube videos
 */

using System;
using System.Collections.Generic;

public class Comment
{
    private string _commenterName;
    private string _stringText;

    public Comment(string name, string text)
    {
        _commenterName = name;
        _stringText = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($" - {_commenterName}: \"{_stringText}\"");
    }
}
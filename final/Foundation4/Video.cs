using System;

internal class Video
{
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments;

    // Constructor
    public Video(string title, string author, int lengthInSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
        this.comments = new List<Comment>();
    }

    // Getters and setters
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public int LengthInSeconds
    {
        get { return lengthInSeconds; }
        set { lengthInSeconds = value; }
    }

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    // Method to calculate video statistics
public string GetVideoStatistics()
{
    int totalComments = GetNumberOfComments();
    double averageCommentLength = comments.Any() ? comments.Average(c => c.Text.Length) : 0;

    string statistics = $"Video Statistics for '{title}':\n";
    statistics += $"Author: {author}\n";
    statistics += $"Length: {lengthInSeconds} seconds\n";
    statistics += $"Number of Comments: {totalComments}\n";
    statistics += $"Average Comment Length: {averageCommentLength:F2} characters\n";

    return statistics;
}

    }

internal class Program
{
    private static void Main()
    {
        // Sample usage
        Video video = new Video("Sample Video", "Sample Author", 180);
        video.AddComment(new Comment("User1", "Great video!"));
        video.AddComment(new Comment("User2", "I learned a lot."));

        Console.WriteLine(video.GetVideoStatistics());
    }
}

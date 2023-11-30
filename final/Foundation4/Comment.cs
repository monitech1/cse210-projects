// Comment.cs
internal class Comment
{
    private string userName;
    private string text;

    public Comment(string userName, string text)
    {
        this.userName = userName;
        this.text = text;
    }

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    public string Text
    {
        get { return text; }
        set { text = value; }
    }
}

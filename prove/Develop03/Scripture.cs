using System;


class Scripture
{
    public List<Word> Words { get; private set; }
    public ScriptureReference Reference { get; private set; }

    public Scripture(string reference, string text)
    {
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
        Reference = new ScriptureReference(reference);
    }

    public void Display()
    {
        Console.WriteLine($"{Reference.Reference}: {GetVisibleText()}");
    }

    public string GetVisibleText()
    {
        return string.Join(" ", Words.Where(word => !word.IsHidden).Select(word => word.Text));
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        var visibleWords = Words.Where(word => !word.IsHidden).ToList();
        for (int i = 0; i < count; i++)
        {
            if (visibleWords.Count > 0)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].IsHidden = true;
                visibleWords.RemoveAt(index);
            }
        }
    }
}

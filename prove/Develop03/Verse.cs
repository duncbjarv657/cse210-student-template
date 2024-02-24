using System;

class Verse
{
    private List<Word> _words = new List<Word>();

    private bool _check;

    public Verse(String verse)
    {
        string Verse = verse;
        _words = new List<Word>();
        char[] delimeterChars = {' ', ',', '.', ':', '\t'};
        string[] words = verse.Split (delimeterChars);
        foreach(string wordStr in words)
        {
            Word word = new Word(wordStr);
            _words.Add(word);
        }
        _check = false;
    }
    public void Display()

    {
        foreach (Word word in _words)
        {
            word.Display();
            System.Console.Write(" ");
        }
        System.Console.WriteLine();
    }

    private int randomIndex()
    {
        Random random = new Random();
        int verseIndex = random.Next(_words.Count());
        return verseIndex;
    }

    public bool HideWords()
    {
        int count = 0;
        _check = false;
        while(_check == false)
        {
            Word word = new Word("_");
            int verseIndex = randomIndex();
            word = _words [verseIndex];
            count = count + 1;
            if(word.Cleared() == false)
            {
                word.Clear();
                return true;
            }
            if (count > _words.Count() * 3)
            {
                return false;
            }
        }return false;
    }

    public bool Cleared()
    {
        if (_check == true)
        {
            return true;
        }
        else
        {
            foreach (Word word in _words)
            {
                if (word.Cleared() == false)
                {
                    return false;
                }
            }
            _check = true;
            return true;
        }
    }

    public void Clear()
    {
        foreach(Word word in _words)
        {
            word.Clear();
            _check = true;
        }
    }
}
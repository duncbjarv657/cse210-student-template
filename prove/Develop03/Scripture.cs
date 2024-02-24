using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private string _scriptureReference;
    private List<Verse> _verses = new List<Verse>();
    private Random _random = new Random();

    public Scripture(string scriptureReference, List<string> verses)
    {
        _scriptureReference = scriptureReference;
        foreach(string verseStr in verses)
        {
            Verse verse = new Verse(verseStr);
            _verses.Add(verse);
        }
    }

    public void Display()
    {
        System.Console.WriteLine(_scriptureReference);
        foreach (Verse verse in _verses)
        {
            verse.Display();
        }
    }

    public bool HideWords(int number)
    {
        int count = 0;
        int failed = 0;
        while (count < number)
        {
            int verseIndex = _random.Next(_verses.Count());
            Verse verse = _verses[verseIndex];
            if (verse.Cleared() == true) 
            {
                count = count + 1;
            }
            failed = failed + 1;
            if (failed > 100)
            {
                return false;
            }
        }

        return true;
    }

    public bool IsAllHidden()
    {
        foreach (Verse verse in _verses)
        {
            if(verse.Cleared() == false)
            {
                return false;
            }
        }
        return true;
    }

    public bool Clear()
    {
        foreach(Verse verse in _verses)
        {
            verse.Clear();
        }
        return true;
    }
}















// using System;

// class Scripture
// {

//     private string _scriptureReference;

//     private List<Verse> _verses = new List<Verse>();

//     public Scripture(string scriptureReference, List<string> verses)
//     {
//         _scriptureReference = scriptureReference;
//         foreach(string verseStr in verses)
//         {
//             Verse verse = new Verse(verseStr);
//             _verses.Add(verse);
//         }
//     }

//     public void Display()
//     {
//         System.Console.WriteLine(_scriptureReference);
//         foreach (Verse verse in _verses)
//         {
//             verse.Display();
//         }
//     }

//     public bool HideWords (int number)
//     {
//         int count = 0;
//         int failed = 0;
//         while (count < number)
//         {
//             Random random = new Random();
//             int verseIndex = random.Next(_verses.Count());
//             Verse verse = new Verse("");
//             verse = _verses[verseIndex];
//             if (verse.Cleared() == true) 
//             {
//                 count = count + 1;

//             }
//             failed = failed + 1;
//             if (failed > 100)
//             {
//                 return false;
//             }
//         }

//         return true;
//     }

//     public bool IsAllHidden()
//     {
//         foreach (Verse verse in _verses)
//         {
//             if(verse.Cleared() == false)
//             {
//                 return false;
//             }
//         }
//         return true;
//     }

//     public bool Clear()
//     {
//         foreach(Verse verse in _verses)
//         {
//             verse.Clear();
//         }
//         return true;
//     }
// }
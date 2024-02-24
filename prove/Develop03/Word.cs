using System;

class Word
{
    private string _text = "";
    private bool _hidden = false;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }
    public void Display()
    {
        if (_hidden == true)
        {
            foreach(char character in _text)
            {
                System.Console.Write("_");
            }
        }
        else
        {
            System.Console.Write(_text);
        }
    }
    public void Clear()
    {
        _hidden = true;
    }
    public bool Cleared()
    {
        return _hidden;
    }
}
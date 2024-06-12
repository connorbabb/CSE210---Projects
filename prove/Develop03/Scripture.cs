using System;
using System.Diagnostics;

class Scripture
{    
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private string _text;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;

        List<string> wordList = new List<string>(_text.Split(" "));
        foreach (string word in wordList)
        {
            Word word1 = new Word(word);
            _words.Add(word1);
            Console.WriteLine(word1.GetRenderedWord(word1));
        }
    }

    public string printWords()
    {
        string script = "";
        foreach (Word word in _words)
        {
            script = script + word.GetRenderedWord(word) + " ";
        }
        return script;
    }
    public void HideWords()
    {
        int length = _words.Count();
        Random random = new Random();
        int count = 0;
        while (count < 3 && IsCompletelyHidden(_words) == false)
        {
            int random1 = random.Next(length);
                if (_words[random1].GetIsHidden(_words[random1]) == false)
                {
                    _words[random1].Hide();
                    count++;
                }
        }
    }

    public string GetRenderedText(Scripture scripture) 
    {
        string text = scripture._reference + " " + scripture._text;
        return text;
    }
    public bool IsCompletelyHidden(List<Word> words) 
    {
        foreach (Word word in words)
        {
            if (word.GetIsHidden(word) == false)
            {
                return false;
            }
        }
        return true;
    }

    public List<Word> GetList()
    {
        return _words;
    }
}
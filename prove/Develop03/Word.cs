using System;
using System.IO.Compression;

class Word
{    
    private string _text;
    private bool _isHidden;
    private string _encodedText;

    public Word(string text) 
    {
        _text = text;
        _encodedText = text;
    }

    public void Hide() 
    {
        int length = _text.Length;
        string multipliedString;
        if (_text[length - 1] == '.')
        {
            multipliedString = string.Concat(Enumerable.Repeat("_", length - 1));
            multipliedString = multipliedString + '.';
        }
        else if (_text[length - 1] == ',')
        {
            multipliedString = string.Concat(Enumerable.Repeat("_", length - 1));
            multipliedString = multipliedString + ',';
        }
        else if (_text[length - 1] == ';')
        {
            multipliedString = string.Concat(Enumerable.Repeat("_", length - 1));
            multipliedString = multipliedString + ';';
        }
        else
        {
            multipliedString = string.Concat(Enumerable.Repeat("_", length));
        }
        _text = multipliedString;
    }
    public void Show() 
    {
        _text = _encodedText;
    }
    public string GetRenderedWord(Word word) 
    {
        return word._text;
    }
    public bool GetIsHidden(Word word) 
    {
        foreach (char c in word._text)
            {
                if (c != '_' && c != '.' && c != ',' && c != ';')
                {
                    _isHidden = false;
                    return false;
                }
            }
        _isHidden = true;
        return true;
    }
}
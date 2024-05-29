using System;

class Reference
{    
    private string _book;
    private string _chapter;
    private string _verses;
    private string _endVerse;

    public Reference(string book, string chapter, string verse) 
    {
        _book = book;
        _chapter = chapter;
        _verses = verse;
        _endVerse = "";
    }
    public Reference(string book, string chapter, string verse, string endVerse) 
    {
        _book = book;
        _chapter = chapter;
        _verses = verse;
        _endVerse = endVerse;
    }

    public override string ToString() 
    {
        if (_endVerse == "")
        {
            return $"{_book} {_chapter}:{_verses} ";
        }
        else
        {
            return $"{_book} {_chapter}:{_verses}-{_endVerse} ";
        }
    }
}
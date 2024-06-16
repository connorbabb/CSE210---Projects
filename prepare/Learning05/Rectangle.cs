using System;
using System.Reflection.Metadata.Ecma335;

public class Rectangle : Shape
{
    private float _side01;
    private float _side02;

    public Rectangle(string color, float side01, float side02) : base(color)
    {
        _side01 = side01;
        _side02 = side02;
    }

    public override float GetArea()
    {
        return _side01 * _side02;
    }
}
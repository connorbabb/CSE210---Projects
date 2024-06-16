using System;
using System.Reflection.Metadata.Ecma335;

public class Circle : Shape
{
    private float _radius;

    public Circle(string color, float radius) : base(color)
    {
        _radius = radius;
    }

    public override float GetArea()
    {
        return (float)(Math.PI * Math.Pow( _radius, 2));
    }
}
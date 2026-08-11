using System;

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
        SetColor(color);
    }

    public override double GetArea()
    {
        double pi = Math.PI;
        double area = pi * (_radius * _radius);
        return area;
    }
    
}

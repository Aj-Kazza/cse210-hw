using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width, string color) : base(color)
    {
        _length = length;
        _width = width;
        SetColor(color);
    }

    public override double GetArea()
    {
        double area = _width * _length;
        return area;
    }
    
}

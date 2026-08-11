using System;

public class Square : Shape
{
    private double _side;

    public Square(double side, string color) : base(color)
    {
        _side = side;
        SetColor(color);
    }

    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
    
}

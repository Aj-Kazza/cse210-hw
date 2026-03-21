using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(1);
        string f1String = f1.GetFractionString();
        Console.WriteLine(f1String);
        double f1Double = f1.GetDecimalValue();
        Console.WriteLine(f1Double);

        Fraction f2 = new Fraction(5);
        string f2String = f2.GetFractionString();
        Console.WriteLine(f2String);
        double f2Double = f2.GetDecimalValue();
        Console.WriteLine(f2Double);

        Fraction f3 = new Fraction(3, 4);
        string f3String = f3.GetFractionString();
        Console.WriteLine(f3String);
        double f3Double = f3.GetDecimalValue();
        Console.WriteLine(f3Double);

        Fraction f4 = new Fraction(1, 3);
        string f4String = f4.GetFractionString();
        Console.WriteLine(f4String);
        double f4Double = f4.GetDecimalValue();
        Console.WriteLine(f4Double);
        
    }
}
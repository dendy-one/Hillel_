using System;

public class Circle : Shape
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public double Radius { get; set; }

    public Circle(int x, int y, double radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }

    public override void Move(int deltaX, int deltaY)
    {
        X += deltaX;
        Y += deltaY;
        Console.WriteLine($"Коло перенесено на ({X}, {Y})");
    }
}

using System;

public class Rectangle : Shape
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public double Width { get; private set; }
    public double Height { get; private set; }

    public Rectangle(int x, int y, double width, double height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    public override void Move(int deltaX, int deltaY)
    {
        X += deltaX;
        Y += deltaY;
        Console.WriteLine($"Прямокутник переміщено до ({X}, {Y})");
    }

    public void Resize(Vector vector)
    {
        Width += vector.X;
        Height += vector.Y;
        Console.WriteLine($"Розмір прямокутника змінено на {Width} x {Height}");
    }
}

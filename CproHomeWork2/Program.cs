using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;


        Circle circle = new Circle(0, 0, 5);
        circle.Move(10, 15);


        Rectangle rectangle = new Rectangle(0, 0, 20, 10);
        rectangle.Move(5, 5);


        Vector resizeVector = new Vector(10, 20);
        rectangle.Resize(resizeVector);


        Console.WriteLine($"Довжина вектора: {resizeVector.Length()}");
        Console.ReadKey();
    }
}

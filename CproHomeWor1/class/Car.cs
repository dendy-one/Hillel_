using System;

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    private double _mileage;

    public int Age
    {
        get
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - Year;
        }
    }

    public double Mileage
    {
        get { return _mileage; }
        private set { _mileage = value; }
    }

    public Car(string brand, string model, int year, double mileage)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Mileage = mileage;
    }

    public void Drive(double distance)
    {
        if (distance > 0)
        {
            

            Mileage += distance;
            Console.WriteLine($"Пробіг автомобіля збільшено на {distance} км. Загальний пробіг: {Mileage} км.");
        }
        else
        {
            Console.WriteLine("Некоректне значення відстані. Пробіг не змінено.");
        }
    }

    ~Car()
    {
        

        Console.WriteLine($"Об'єкт автомобіля {Brand} {Model} видалено.");
    }
}

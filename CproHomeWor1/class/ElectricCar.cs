using System;

class ElectricCar : Car
{
    public double BatteryCapacity { get; set; }

    public ElectricCar(string brand, string model, int year, double mileage, double batteryCapacity)
        : base(brand, model, year, mileage)
    {
        BatteryCapacity = batteryCapacity;
    }

    public void Charge(double amount)
    {
        if (amount > 0)
        {
            

            BatteryCapacity += amount;
            Console.WriteLine($"Заряд батареї збільшено на {amount} кВт·год.");
        }
        else
        {
            Console.WriteLine("Некоректне значення заряду. Заряд батареї не змінено.");
        }
    }

    public new void Drive(double distance)
    {
       

        if (distance > 0)
        {
            base.Drive(distance);
            double energyConsumption = distance * 0.1;
            BatteryCapacity -= energyConsumption;

            // Запобігаємо зниженню ємності нижче 0
            if (BatteryCapacity < 0)
            {
                BatteryCapacity = 0;
            }

            Console.WriteLine($"Рівень заряду батареї після поїздки: {BatteryCapacity:F2} кВт·год.");
        }
        else
        {
            Console.WriteLine("Некоректне значення відстані. Пробіг не змінено.");
        }
    }
}

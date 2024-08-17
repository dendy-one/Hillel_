using System;

class Program
{
   


    static void Main()
    {
        try
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //дані звичайної машини

            Console.WriteLine("Введіть інформацію про звичайний автомобіль:");
            Console.Write("Марка: ");
            string brand = Console.ReadLine();
            Console.Write("Модель: ");
            string model = Console.ReadLine();
            Console.Write("Рік випуску: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Пробіг (км): ");
            double mileage = double.Parse(Console.ReadLine());

            Car myCar = new Car(brand, model, year, mileage);

            Console.WriteLine($"\nМарка: {myCar.Brand}, Модель: {myCar.Model}, Рік: {myCar.Year}, Пробіг: {myCar.Mileage} км, Вік: {myCar.Age} років");

            //данні електро машини
            Console.WriteLine("\nВведіть інформацію про електромобіль:");
            Console.Write("Марка: ");
            string eBrand = Console.ReadLine();
            Console.Write("Модель: ");
            string eModel = Console.ReadLine();
            Console.Write("Рік випуску: ");
            int eYear = int.Parse(Console.ReadLine());
            Console.Write("Пробіг (км): ");
            double eMileage = double.Parse(Console.ReadLine());
            Console.Write("Ємність батареї (кВт·год): ");
            double batteryCapacity = double.Parse(Console.ReadLine());

            ElectricCar myElectricCar = new ElectricCar(eBrand, eModel, eYear, eMileage, batteryCapacity);

            Console.WriteLine($"\nМарка: {myElectricCar.Brand}, Модель: {myElectricCar.Model}, Рік: {myElectricCar.Year}, Пробіг: {myElectricCar.Mileage} км, Ємність батареї: {myElectricCar.BatteryCapacity} кВт·год");

            
            Console.Write("\nВведіть відстань для поїздки на звичайному автомобілі (км): ");
            double distance = double.Parse(Console.ReadLine());
            myCar.Drive(distance);

            Console.Write("\nВведіть відстань для поїздки на електромобілі (км): ");
            double eDistance = double.Parse(Console.ReadLine());
            myElectricCar.Drive(eDistance);

            Console.Write("\nВведіть кількість заряду для електромобіля (кВт·год): ");
            double chargeAmount = double.Parse(Console.ReadLine());
            myElectricCar.Charge(chargeAmount);

           
            Console.WriteLine($"\nПісля поїздки і зарядки:");
            Console.WriteLine($"Звичайний автомобіль - Пробіг: {myCar.Mileage} км, Вік: {myCar.Age} років");
            Console.WriteLine($"Електромобіль - Пробіг: {myElectricCar.Mileage} км, Ємність батареї: {myElectricCar.BatteryCapacity} кВт·год");

            
            myElectricCar = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка введення даних. Переконайтеся, що всі числові значення введені правильно.");
        }
    }
}

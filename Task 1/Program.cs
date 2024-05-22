using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, number4;
            Console.WriteLine("Enter the first number");
            number1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth number");
            number4 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"{(number1 * 1000)+(number2*100)+(number3*10)+number4}");
            Console.ReadKey();
        }
    }
}

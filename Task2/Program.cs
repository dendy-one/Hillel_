using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int number2 = 0;
            while (number != 0)
            {
                number2 = number2 * 10 + number % 10;
                number /= 10;
            }
            Console.WriteLine(number2);
            Console.ReadKey();


            
        }

    }
}

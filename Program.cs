using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1 // Оголошення нового простору імен
{
    class Program // Оголошення нового класу
    {
        static void Main(string[] args) // Оголошення нового методу
        {
            int number; // Значення для оператора
            do
            {

                Console.Write("Set a value X = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Set a value Y = ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Set a value Z = ");
                int z = Convert.ToInt32(Console.ReadLine());
                number = x; 
                double a = (Math.Pow(x, 2) + 4) / (Math.Sin(z) + (y / 2));
                Console.WriteLine($"a = {a}");

                if (x < -10) Console.WriteLine($"X less than -10");
                if ((x > -10) && (x < -1)) Console.WriteLine($"X less than -1");
                if ((x > 1) && (x < 10)) Console.WriteLine($"X more for 1");
                if (x > 10) Console.WriteLine($"X more for 10");


                if (a < 0) Console.WriteLine($"The result is negative");
                if (a > 0) Console.WriteLine($"The result is positive");
                Console.ReadKey();
            }
            while (number != 0);
        }
    }
}

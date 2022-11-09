using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab9_2_
{
    class Program
    {
        public const double PI = 3.14;
        static void Main(string[] args)
        {
            double R = 1740;
            double S;
            double V;

            S = 4 * PI * Math.Pow(R, 2);
            V = (4 / 3) * PI* Math.Pow(R, 3);

            Console.WriteLine($"Volume of the planet is: {V}");
            Console.WriteLine($"Area of the planet is: {S}");
        }
    }
}

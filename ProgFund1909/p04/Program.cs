using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04
{
    class Program
    {
        static void Main(string[] args)
        {
            string beverage = Console.ReadLine();
            double size = double.Parse(Console.ReadLine());
            double kcalPer100 = double.Parse(Console.ReadLine());
            double sugarPer100 = double.Parse(Console.ReadLine());

            double kcal = (size / 100) * kcalPer100;
            double sugar = (size / 100) * sugarPer100;

            Console.WriteLine("{0}ml {1}: \n{2}kcal, {3}g sugars",size, beverage, kcal,sugar);

        }
    }
}

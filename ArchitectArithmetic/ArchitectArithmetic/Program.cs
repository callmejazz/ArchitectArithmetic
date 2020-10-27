using System;

namespace ArchitectArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalArea = rectangle(2500, 1500) + triangle(500, 750) + 0.5 * circle(375);
            double totalCost = totalArea * 180;
            Console.WriteLine(totalCost);
        }
        static double rectangle(double length, double width) 
        {
            return length * width;
        
        }
        static double circle(double radius)
        {

            return Math.PI * Math.Pow(radius, 2);
        }
        static double triangle(double bottom, double height) 
        {
            return 0.5 * bottom * height;
        }
    }
}

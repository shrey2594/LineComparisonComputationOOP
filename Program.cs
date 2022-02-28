using System;

namespace LineComparisonProblemOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Problem using OOP Concept.");
            Console.WriteLine("");
            Console.WriteLine("Enter x coordinate of point1");
            int x1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of point1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x coordinate of point2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of point2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            LengthCalculation lengthCalculation = new LengthCalculation();
            lengthCalculation.calculateLength(x1,y1,x2,y2);
        }
    }

}
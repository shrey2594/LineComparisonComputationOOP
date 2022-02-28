using System;

namespace LineComparisonProblemOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Problem using OOP Concept.");
            Console.WriteLine("");
            Console.WriteLine("Enter x coordinate of Line 1 Point 1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of Line 1 Point 1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x coordinate of Line 1 Point 2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of Line 1 Point 2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x coordinate of Line 2 Point 1:");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of Line 2 Point 1:");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x coordinate of Line 2 Point 2:");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of Line 2 Point 2:");
            int y4 = Convert.ToInt32(Console.ReadLine());
            LengthCalculation lengthCalculation = new LengthCalculation();
            CheckEquality checkEquality = new CheckEquality();
            double L1 = lengthCalculation.calculateLength(x1, y1, x2, y2);
            double L2 = lengthCalculation.calculateLength(x3, y3, x4, y4);
            checkEquality.LineEqualityCheck(L1, L2);
        }
    }

}
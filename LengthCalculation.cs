﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblemOOP
{
    public class LengthCalculation
    {
        public double calculateLength(int x1, int y1, int x2, int y2)
        {
                double sum = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
                double lineLength = Math.Sqrt(sum);
                Console.WriteLine("The length of Line is:" + lineLength);
                return lineLength;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblemOOP
{
    public class CheckEquality
    {
        public void LineEqualityCheck(double length1, double length2)
        {
            if (length1.Equals(length2))
            {
                Console.WriteLine("Line1 is equal to Line2");
            }
            else
            {
                Console.WriteLine("Line1 is not equal to Line2");
            }
        }
    }
}

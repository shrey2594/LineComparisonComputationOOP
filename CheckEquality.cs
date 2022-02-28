using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblemOOP
{
    public class CheckEquality
    {
        public static void LineEqualityCheck(double length1, double length2)
        {
            if (length1.Equals(length2))
            {
                Console.WriteLine("Line1 is equal to Line2");
            }
            else
            {
                LengthComparison lengthComparison = new LengthComparison();
                lengthComparison.Comparison(length1, length2);
            }
        }
    }
}

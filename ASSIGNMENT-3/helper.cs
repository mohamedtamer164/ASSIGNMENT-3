using System;
using System.Collections.Generic;
using System.Text;

namespace ASSIGNMENT_3
{
    internal class helper
    {
        public static void AddBonusPages( ref int  pages)
        {
            pages = pages + 50;

        }

        public static void ApplyDiscount(double[] prices)
        {
            prices[0] = prices[0] - 5;
        }
        public  static void ReplaceArray(ref double[] prices)
        {
            prices = new double[]{ 10.0, 12.5, 15.0 };
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace ASSIGNMENT_3
{
    internal class helper
    {
        public static void AddBonusPages(int pages)
        {
            pages = pages + 50;

        }

        public static void ApplyDiscount(double[] prices)
        {
            prices[0] = prices[0] - 5;
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOOP
{
    class Calculation
    {
        private static double planckConstant = 6.62606896e-34;
        private static double pi = 3.14159;

        public static void ReducedPlanck()
        {
            Console.WriteLine($"{planckConstant / (2 * pi)}");
        }
    }
}

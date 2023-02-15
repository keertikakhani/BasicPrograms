using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class QuotientAndRemainder
    {
        public static void QuotientRemainder()
        {
            Console.WriteLine("Enter the value of Dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("quotient is : " + quotient);

            Console.WriteLine("remainder is : " + remainder);

        }
    }
}

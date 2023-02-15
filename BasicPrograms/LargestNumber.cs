using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class LargestNumber
    {
        public static void Maximum()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("{0} is largest number", num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("{0} is largest number", num2);
            }
            else
                Console.WriteLine("{0} is largest number", num3);

        }
    }
}

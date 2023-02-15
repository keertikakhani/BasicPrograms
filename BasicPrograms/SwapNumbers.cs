using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class SwapNumbers
    {
        public static void Swap()
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swap a = " + a + " b = " + b);
            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("After Swap a = " + a + " b = " + b);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class EvenOdd
    {
        public static void Check()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is even number", number);
            }
            else
                Console.WriteLine("{0} is odd number", number);
        }
    }
}

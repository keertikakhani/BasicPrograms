using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class PrimeFactors
    {
        public static void Prime()
        {
            Console.WriteLine("Enter a Number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime facors are");

            for (int i = 2; number > 1; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i);
                    number = number / i;
                }
            }
        }
    }
}

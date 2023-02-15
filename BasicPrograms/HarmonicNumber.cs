using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class HarmonicNumber
    {
        public static void Harmonic()
        {
            double sum = 0.0;
            Console.WriteLine("Enter the number to print harmonic series");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("1/{0}", i);
                sum = sum + 1 / (double)i;
            }
            Console.WriteLine("sum is : {0}", sum);
        }
    }
}

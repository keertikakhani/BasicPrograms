using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class PowerOf2
    {
        public static void Power()
        {
            int p = 1;
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("2 ^ 0 = 1");
                }
                else
                {
                    p = p * 2;
                    Console.WriteLine("2 ^ {0} : {1}", i, p);
                }
            }
        }
    }
}

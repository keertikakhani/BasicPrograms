using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class Coin
    {
        public static void FlipCoin()
        {
                int heads = 0, tails = 0;
                Console.WriteLine("Number of times you want to flip the coin");
                int number = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= number; i++)
                {
                    Random random = new Random();
                    double value = random.NextDouble();
                    if (value < 0.5)
                    {
                        tails = tails + 1;
                    }
                    else
                        heads = heads + 1;
                }
                Console.WriteLine("tails: {0} and heads: {1}", tails, heads);
                double tailspercentage = (tails * 100) / (tails + heads);
                double headspercentage = (heads * 100) / (tails + heads);
                Console.WriteLine("tails: {0}% heads: {1}%", tailspercentage, headspercentage);
        }
    }
}

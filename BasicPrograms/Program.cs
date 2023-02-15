using System;

namespace BasicPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("C# Basic Programs");

            Coin.FlipCoin();
            CheckLeapYear.Leap();
            PowerOf2.Power();
            HarmonicNumber.Harmonic();
            PrimeFactors.Prime();
            QuotientAndRemainder.QuotientRemainder();
            SwapNumbers.Swap();
            EvenOdd.Check();
            VowelOrConsonant.CheckChararcter();
            LargestNumber.Maximum();

            Console.ReadLine();
        }
    }
}
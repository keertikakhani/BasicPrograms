﻿using System;

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

            Console.ReadLine();
        }
    }
}
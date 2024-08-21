﻿using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Check();
        }
        static void Check()
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}

﻿using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int product = 0;
            if (multiplier > 10)
            {
                Console.WriteLine($"{n} X {multiplier} = {n * multiplier}");
            }
            for (int i = multiplier; i <= 10; i++)
            {
                product = n * i;
                Console.WriteLine($"{n} X {i} = {product}");
            }
        }
    }
}
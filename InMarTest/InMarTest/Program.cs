﻿using System;

namespace InMarTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            { 
                if (i % 3 == 0 && i%5==0)
                    Console.WriteLine("fizzbuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("buzz");
            }
            Console.Read();
        }
    }
}

using System;

class SumIntegers
{
    static void Main()
    {
        // Write a program that reads 3 integer numbers from the console and prints their sum.

        // About
        Console.WriteLine("Input and sum 3 integer values...");
        // Input data
        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("C = ");
        int c = int.Parse(Console.ReadLine());
        // Calculate
        int sum = a + b + c;
        // Output data
        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, sum);
    }
}
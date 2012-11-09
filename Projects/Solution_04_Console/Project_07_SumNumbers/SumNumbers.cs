using System;

class SumNumbers
{
    static void Main()
    {
        /* Write a program that gets a number n and after that gets more n numbers 
         * and calculates and prints their sum.
         */

        // About
        Console.WriteLine("Sum n numbers:");
        // Input data
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        double[] numbers = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}. Input number = ", i + 1);
            numbers[i] = double.Parse(Console.ReadLine());
        }
        // Calculate
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += numbers[i];
        }
        // Output data
        Console.WriteLine("Sum = {0}", sum);
    }
}

using System;

class CalculateSumOfSequence
{
    static void Main()
    {
        // Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

        // About
        Console.WriteLine("Calculate sum of a sequence with accuracy 0.001:");
        // Calculate
        int sign = 1;
        double abs = 1.0; 
        double sum = 1.0;
        for (int i = 2; i <= 1000; i++)
        {
            abs = 1.0 / i;
            sum += sign * abs;
            sign = -sign;
        }
        // Output data
        Console.WriteLine("1 + 1/2 - 1/3 + 1/4 - 1/5 + ... = {0}", sum);
    }
}
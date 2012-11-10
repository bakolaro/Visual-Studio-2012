using System;
using System.Numerics;

class CalculateSumOfSequence
{
    static void Main()
    {
        // Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

        // About
        Console.WriteLine("Calculate sum of a sequence with accuracy 0.001:");
        // Calculate
        /* Accuracy = Absolute value of (Measurement of something - Real value of the measured thing).
         * Here it is obvious that the real value is between the last two calculated sums, so
         * if their difference is less then 0.001, then we could choose the first one of them with
         * possible error less than 0.001 => we should stop calculations just before adding a number less
         * than 0.001, i.e. before our denominator gets greater than 1000.
         * Solution = 1 + 1/(2 * 3) + 1/(4 * 5) + 1/(6 * 7) + ... + 1/(998 * 999) + 1/1000.
         */
        double growingSum = 1.0;
        for (int i = 2; i <= 998; i += 2)
        {
            growingSum += (1.0 / (i * (i + 1)));
        }
        growingSum += 1.0 / 1000;
        // Output data
        Console.WriteLine("1 + 1/2 - 1/3 + 1/4 - 1/5 + ... = {0}", growingSum);
    }
}
using System;
using System.Numerics;

class CalculateSumOfSequence
{
    static void Main()
    {
        // Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

        Console.WriteLine("Calculate sum of a sequence with accuracy 0.001:");

        /* Accuracy = Absolute value of (Measurement of something - Real value of the measured thing).
         * Here it is obvious that the real value is between the last two calculated sums, so
         * if their difference is less then 0.001, then we could choose the first one of them with
         * possible error less than 0.001 => we should stop calculations just before adding a number less
         * than 0.001, i.e. before our denominator gets greater than 1000.
         * Solution = 1 + 1/(2 * 3) + 1/(4 * 5) + 1/(6 * 7) + ... + 1/(998 * 999) + 1/1000.
         */

        // Type double
        double growingSum = 1.0;
        for (int i = 2; i <= 998; i += 2)
        {
            growingSum += (1.0 / (i * (i + 1)));
        }
        growingSum += 1.0 / 1000;
        Console.WriteLine("Sum (double)  = 1 + 1/2 - 1/3 + 1/4 - 1/5 + ... = {0}", growingSum);

        // Type decimal
        decimal growingDecimalSum = 1.0m;
        for (int i = 2; i <= 998; i += 2)
        {
            growingDecimalSum += (1.0m / (i * (i + 1)));
        }
        growingDecimalSum += 1.0m / 1000;
        Console.WriteLine("Sum (decimal) = 1 + 1/2 - 1/3 + 1/4 - 1/5 + ... = {0}", growingDecimalSum);

        /* Calculate sum of a sequence with accuracy 0.001:
         * Sum (double)  = 1 + 1/2 - 1/3 + 1/4 - 1/5 + ... = 1,30735256944018
         * Sum (decimal) = 1 + 1/2 - 1/3 + 1/4 - 1/5 + ... = 1,3073525694401796903327689417
         */
    }
}
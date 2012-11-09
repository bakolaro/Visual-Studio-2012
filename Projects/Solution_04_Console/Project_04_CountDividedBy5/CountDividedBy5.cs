using System;

class CountDividedBy5
{
    static void Main(string[] args)
    {
        /* Write a program that reads two positive integer numbers and prints how many 
         * numbers p exist between them such that the reminder of the division by 5 is
         * 0 (inclusive). Example: p(17,25) = 2.
         */

        // About
        Console.WriteLine("Count numbers divided by 5 between two positive integers:");
        // Test
        uint a, b, p;
        a = 5u; b = 25u; p = countDivisibleNumbers(a, b, 5u);
        Console.WriteLine("p({0}, {1}) = {2}", a, b, p);
        a = 5u; b = 24u; p = countDivisibleNumbers(a, b, 5u);
        Console.WriteLine("p({0}, {1}) = {2}", a, b, p);
        a = 8u; b = 30u; p = countDivisibleNumbers(a, b, 5u);
        Console.WriteLine("p({0}, {1}) = {2}", a, b, p);
        a = 9u; b = 29u; p = countDivisibleNumbers(a, b, 5u);
        Console.WriteLine("p({0}, {1}) = {2}", a, b, p);
        a = 8u; b = 8u; p = countDivisibleNumbers(a, b, 5u);
        Console.WriteLine("p({0}, {1}) = {2}", a, b, p);
        a = 120u; b = 120u; p = countDivisibleNumbers(a, b, 5u);
        Console.WriteLine("p({0}, {1}) = {2}", a, b, p);
        // Input data
        Console.Write("a = ");
        a = uint.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = uint.Parse(Console.ReadLine());
        // Calculation
        p = countDivisibleNumbers(a, b, 5u);
        // Output data
        Console.WriteLine("p({0}, {1}) = {2}", a, b, p);
    }

    static uint countDivisibleNumbers(uint a, uint b, uint denominator)
    {
        uint smaller = a;
        uint greater = b;
        // Let smaller <= larger
        if (a > b)
        {
            smaller = b;
            greater = a;
        }
        /* interval between smaller and greater = many open intervals + one closed interval;
         * every open interval = [smaller + k * denominator, smaller + k * denominator + denominator);
         * every open interval contains exactly 1 number divisible by denominator;
         * closed interval contains 0 or 1;
         */
        uint positiveDifference = greater - smaller;
        uint openIntervals = positiveDifference / denominator;
        uint remainderOfGreater = greater % denominator;
        uint openIntervalsEnd = greater - (positiveDifference % denominator);
        uint remainderOfOpenIntervalsEnd = openIntervalsEnd % denominator;
        bool closedIntervalContainsDivisible = (remainderOfOpenIntervalsEnd == 0) || (remainderOfOpenIntervalsEnd > remainderOfGreater);
        return openIntervals + (closedIntervalContainsDivisible ? 1u : 0u);
    }
}
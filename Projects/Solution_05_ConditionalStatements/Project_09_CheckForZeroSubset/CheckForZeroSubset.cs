using System;

class CheckForZeroSubset
{
    static void Main()
    {
        /* We are given 5 integer numbers. Write a program that checks if the sum
         * of some subset of them is 0. Example: 3, -2, 1, 1, 8 -> 1+1-2=0.
         */

        // About
        Console.WriteLine("Check set of 5 integers for a zero-sum subset:");
        // Input data
        int[] vars = new int[5];
        for (int i = 0; i < vars.Length; i++)
        {
            Console.Write("Variable[{0}] = ", i);
            vars[i] = int.Parse(Console.ReadLine());
        }
        // Calculate
        /* A binary digit could be assigned to each element in a set, indicating if
         * it belongs to a certain subset (0 - does not belong, 1 - belongs). If every
         * element in the set is identified by an ordinal number, then every possible
         * subset corresponds to a single binary number. The empty subset corresponds
         * to 0. A set of 5 elements has 32 subsets, including the empty subset,
         * since 11111(2) = 1 + 2 + 4 + 8 + 16 = 31. A number from 1 to 31 could be 
         * assigned to each non-empty subset.
         */
        int subsetCode = 0;
        for (int i = 1; i < 32; i++)
        {
            int sum = 0;
            for (int j = 0; j < vars.Length; j++)
            {
                if(((i >> j) & 1) > 0)
                {
                    sum += vars[j];
                }
            }
            if (sum == 0)
            {
                subsetCode = i;
            }
        }
        // Output data
        if (subsetCode > 0)
        {
            Console.WriteLine("This set has at least one zero-sum subset:");
            for (int j = 0; j < vars.Length; j++)
            {
                if (((subsetCode >> j) & 1) > 0)
                {
                    Console.Write("{0} ", vars[j]);
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("This set has no zero-sum subsets.");
        }
    }
}

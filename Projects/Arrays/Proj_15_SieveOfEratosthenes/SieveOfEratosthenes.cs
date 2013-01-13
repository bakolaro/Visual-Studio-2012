using System;
using System.IO;

class SieveOfEratosthenes
{
    /* Write a program that finds all prime numbers in the 
     * range [1...10 000 000]. Use the sieve of Eratosthenes
     * algorithm (find it in Wikipedia).
     */
    static void Main()
    {
        int max = 10000000;
        // initially all numbers i (1 to max) are considered prime,
        // i.e. isComposite[i - 1] = false
        bool[] isComposite = new bool[max];
        // i = 1 is not prime
        isComposite[0] = true;
        // i = 2 is prime
        isComposite[1] = false;
        int number = 2;
        while(number <= max)
        {
            if (!isComposite[number - 1])
            {
                int nextMultiple = number + number;
                while (nextMultiple <= max)
                {
                    isComposite[nextMultiple - 1] = true;
                    nextMultiple += number;
                }
            }
            number++;
        }
        // Redirect output to file
        StreamWriter writer = new StreamWriter(string.Format("PrimeNumbers{0}.txt", max));
        Console.SetOut(writer);

        Console.WriteLine("List of all prime numbers from 1 to {0:#,###}:", max);
        int counter = 0;
        for (int i = 0; i < isComposite.Length; i++)
        {
            if (!isComposite[i])
            {
                Console.Write("{0,10}", i + 1);
                counter++;
                if(counter % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("There are {0} prime numbers between 1 and {1:#,###}.", counter, max);
        writer.Close();
        // Print on screen all prime numbers from 1 to 100
        /*
        for (int i = 1; i < isComposite.Length + 1; i++)
        {
            if (i > 1 && i % 2 > 0 && i % 3 > 0 && i % 5 > 0 && i % 7 > 0
                || i == 2 || i == 3 || i == 5 || i == 7)
            {
                Console.Write("{0,10}", i);
            }
        }
        Console.WriteLine();
        */
    }
}

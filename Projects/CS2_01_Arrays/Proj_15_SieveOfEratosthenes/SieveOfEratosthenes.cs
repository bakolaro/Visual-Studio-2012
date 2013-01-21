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
        Console.Write("Export a list of all prime numbers from 1 to Max, max = ");
        int max = int.Parse(Console.ReadLine());
        //
        // isComposite[i] indicates if i is composite
        // 
        // Initially all numbers i (from 0 to max) are considered to be prime,
        // i.e. isComposite[i] == false
        //
        bool[] isComposite = new bool[max + 1];
        //
        // i = 0 and i = 1 are neither composite, nor prime
        // i = 2 is prime
        isComposite[1] = false;
        int number = 2;
        while(number <= max)
        {
            if (!isComposite[number])
            {
                int nextMultiple = number + number;
                while (nextMultiple <= max)
                {
                    isComposite[nextMultiple] = true;
                    nextMultiple += number;
                }
            }
            number++;
        }
        // Redirect output to file:
        // 1. Get the original IO streams
        TextWriter standardWriter = Console.Out;
        // 2. Create new output stream
        StreamWriter writer = new StreamWriter(string.Format("PrimeNumbers{0}.txt", max));
        Console.SetOut(writer);
        // 3. Write to file
        Console.WriteLine("List of all prime numbers from 1 to {0:#,###}:", max);
        int counter = 0;
        for (int i = 2; i <= max; i++)
        {
            if (!isComposite[i])
            {
                Console.Write("{0,10}", i);
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
        Console.SetOut(standardWriter);
        // Get back to standard output stream
        Console.WriteLine("List of {0} prime numbers from 1 to {1:#,###} was exported to:\r\n" +
            "bin/Debug/PrimeNumbers{1}.txt", counter, max);
    }
}

using System;

class BonusScores
{
    static void Main()
    {
        /* Write a program that applies bonus scores to given scores in the
         * range [1..9]. The program reads a digit as an input. If the digit
         * is between 1 and 3, the program multiplies it by 10; if it is 
         * between 4 and 6, multiplies it by 100; if it is between 7 and 9, 
         * multiplies it by 1000. If it is zero or if the value is not a digit,
         * the program must report an error. Use a switch statement and at 
         * the end print the calculated new value in the console.
         */

        // About
        Console.WriteLine("Bonus scores:");
        // Input data
        Console.WriteLine("Input score [1..9] (press a button)");
        char scoreChar = Console.ReadKey(true).KeyChar;
        // Output data
        Console.WriteLine("Initial score = " + scoreChar);
        switch (scoreChar)
        {
            case '1':
                Console.WriteLine("Score + bonus = 10");
                break;
            case '2':
                Console.WriteLine("Score + bonus = 20");
                break;
            case '3':
                Console.WriteLine("Score + bonus = 30");
                break;
            case '4':
                Console.WriteLine("Score + bonus = 400");
                break;
            case '5':
                Console.WriteLine("Score + bonus = 500");
                break;
            case '6':
                Console.WriteLine("Score + bonus = 600");
                break;
            case '7':
                Console.WriteLine("Score + bonus = 7000");
                break;
            case '8':
                Console.WriteLine("Score + bonus = 8000");
                break;
            case '9':
                Console.WriteLine("Score + bonus = 9000");
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }
    }
}

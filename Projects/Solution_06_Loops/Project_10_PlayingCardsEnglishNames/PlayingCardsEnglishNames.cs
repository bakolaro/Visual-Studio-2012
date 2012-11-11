using System;

class PlayingCardsEnglishNames
{
    static void Main()
    {
        /* Write a program that prints all possible cards from a standard
         * deck of 52 cards (without jokers). The cards should be printed
         * with their English names. Use nested for loops and switch-case.
         */

        // About
        Console.WriteLine("A standard deck of playing cards:");
        // Output data
        string[] suits = {"Spades", "Hearts", "Diamonds", "Clubs"};
        string[] highRanks = {"Ace", "King", "Queen", "Jack"};
        foreach (string suit in suits)
        {
            foreach (string rank in highRanks)
            {
                Console.WriteLine("{0,12} of {1,-12}", rank, suit);
            }
            for (int rank = 10; rank > 1; rank--)
            {
                Console.WriteLine("{0,12} of {1,-12}", rank, suit);
            }
        }
    }
}

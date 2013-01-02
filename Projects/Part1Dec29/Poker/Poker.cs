using System;

class Poker
{
    static void Main()
    {
        char[] cards = new char[5];
        for (int i = 0; i < 5; i++)
		{
            // inputs '1' instead of "10"
            cards[i] = Console.ReadLine()[0];
		}
        // sort order: A, 2, 3, ... 10, J, Q, K, A
        char[] ranks = {'2', '3', '4', '5', '6', '7', '8', '9', '1', 'J', 'Q', 'K', 'A'};
        int[] countByRanks = new int[13];
        for (int rankId = 0; rankId < 13; rankId++)
        {
            int counter = 0;
            for (int cardId = 0; cardId < 5; cardId++)
            {
                if (cards[cardId] == ranks[rankId])
                {
                    counter++;
                }
            }
            countByRanks[rankId] = counter;
        }

        int[] x = new int[6];
        for (int rankId = 0; rankId < 13; rankId++)
        {
            x[countByRanks[rankId]]++;
        }

        if (x[5] == 1)
        {
            Console.WriteLine("Impossible");
        }
        else if (x[4] == 1)
        {
            Console.WriteLine("Four of a Kind");
        }
        else if (x[3] == 1 && x[2] == 1)
        {
            Console.WriteLine("Full House");
        }
        else if (x[3] == 1 && x[1] == 2)
        {
            Console.WriteLine("Three of a Kind");
        }
        else if (x[2] == 2 && x[1] == 1)
        {
            Console.WriteLine("Two Pairs");
        }
        else if (x[2] == 1 && x[1] == 3)
        {
            Console.WriteLine("One Pair");
        }
        else if (x[1] == 5)
        {
            int consequtiveOnes = 0, maxOnes = 0;
            for (int rankId = 0; rankId < 13; rankId++)
            {
                if (countByRanks[rankId] == 0)
                {
                    consequtiveOnes = 0;
                }
                if (countByRanks[rankId] == 1)
                {
                    consequtiveOnes++;
                }
                maxOnes = consequtiveOnes > maxOnes ? consequtiveOnes : maxOnes;
            }
            if (maxOnes == 5 ||
                (countByRanks[0] == 1 && countByRanks[1] == 1 && countByRanks[2] == 1 && countByRanks[3] == 1
                 && countByRanks[12] == 1))
            {
                Console.WriteLine("Straight");
            }
            else
            {
                Console.WriteLine("Nothing");
            }
        }
    }
}

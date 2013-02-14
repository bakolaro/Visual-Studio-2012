using System;
using System.Text;

class GenomeDecoder
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        string encodedGenomeSequence = Console.ReadLine();

        // M <= N
        // encodedGenomeSequence contains only decimal digits and
        // letters A, C, G, and T

        StringBuilder decodedGenomeSequence = new StringBuilder(100000);
        StringBuilder formattedGenomeSequence = new StringBuilder(200000);


        int counter = 0;
        foreach (char symbol in encodedGenomeSequence)
        {
            if (symbol == 'A' || symbol == 'C' || symbol == 'G' || symbol == 'T')
            {
                decodedGenomeSequence.Append(symbol, counter > 0 ? counter : 1);
                counter = 0;
            }
            else
            {
                counter = counter * 10 + symbol - 48;
            }
        }
        int d = decodedGenomeSequence.Length;
        int countOutputLines = d / N + (d % N > 0 ? 1 : 0);
        int firstColumnWidth = countOutputLines.ToString().Length;
        int countSpacesPerLine = N / M - 1 + (N % M > 0 ? 1 : 0);
        int countRemainder = N % M;

        string decodedGenomeString = decodedGenomeSequence.ToString();
        for (int i = M, j = N, k = 0; k < d; i += M)
        {
            if (i < j)
            {
                if (i < d)
                {
                    formattedGenomeSequence
                        .Append(decodedGenomeString, k, i - k);
                    formattedGenomeSequence.Append(' ');
                    k = i;
                }
                else
                {
                    formattedGenomeSequence
                        .Append(decodedGenomeString, k, d - k);
                    k = d;
                }
            }
            else
            {
                if (j < d)
                {
                    formattedGenomeSequence
                        .Append(decodedGenomeString, k, j - k);
                    formattedGenomeSequence.Append('~');
                    k = j;
                    i = j;
                    j += N;
                }
                else
                {
                    formattedGenomeSequence
                        .Append(decodedGenomeString, k, d - k);
                    k = d;
                }
            }
        }

        string[] lines = formattedGenomeSequence.ToString().Split('~');
        for (int j = 0; j < lines.Length; j++)
        {
            Console.WriteLine("{0," + firstColumnWidth + "} {1}",
                j + 1, lines[j]);
        }
    }
}

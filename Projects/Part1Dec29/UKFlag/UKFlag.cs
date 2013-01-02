using System;

class UKFlag
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        char[,] ukFlag = new char[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if(i == N / 2 && j == N / 2)
                {
                    ukFlag[i, j] = '*';
                }
                else if (i == N / 2)
                {
                    ukFlag[i, j] = '-';
                }
                else if (j == N / 2)
                {
                    ukFlag[i, j] = '|';
                }
                else if (i == j)
                {
                    ukFlag[i, j] = '\\';
                }
                else if (i + j == N - 1)
                {
                    ukFlag[i, j] = '/';
                }
                else
                {
                    ukFlag[i, j] = '.';
                }
            }
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(ukFlag[i, j]);
            }
            Console.WriteLine();
        }
    }
}

using System;

class Sheets
{
	static void Main()
	{
		int N = int.Parse(Console.ReadLine());
		int[] maxPieces = new int[11];
		for (int i = 0; i < 11; i++)
		{
			maxPieces[i] = 1 << (10 - i);
		}
		for (int i = 0; i < 11; i++)
		{
			if (((N >> i) & 1) != 1)
			{
				Console.WriteLine("A" + (10 - i));
			}
		}
	}
}

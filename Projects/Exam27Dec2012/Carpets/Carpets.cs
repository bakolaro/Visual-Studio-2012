using System;

class Carpets
{
	static void Main()
	{
		int N = int.Parse(Console.ReadLine());
		
		for (int romb = 1; romb <= N / 2; romb++)
		{

			int space = N / 2 - romb;

			for (int i = 0; i < space; i++)
			{
				Console.Write('.');
			}
			for (int i = 0; i < romb; i++)
			{
				if (i % 2 == 0)
				{
					Console.Write('/');
				}
				else
				{
					Console.Write(' ');
				}
			}
			for (int i = 0; i < romb; i++)
			{
				if ((i % 2 == 0) ^ (romb % 2 == 0))
				{
					Console.Write('\\');
				}
				else
				{
					Console.Write(' ');
				}
			}
			for (int i = 0; i < space; i++)
			{
				Console.Write('.');
			}
			Console.WriteLine();
		}
		for (int romb = N / 2; romb >= 1; romb--)
		{

			int space = N / 2 - romb;
			for (int i = 0; i < space; i++)
			{
				Console.Write('.');
			}
			for (int i = 0; i < romb; i++)
			{
				if (i % 2 == 0)
				{
					Console.Write('\\');
				}
				else
				{
					Console.Write(' ');
				}
			}
			for (int i = 0; i < romb; i++)
			{
				if ((i % 2 == 0) ^ (romb % 2 == 0))
				{
					Console.Write('/');
				}
				else
				{
					Console.Write(' ');
				}
			}
			for (int i = 0; i < space; i++)
			{
				Console.Write('.');
			}
			Console.WriteLine();
		}
	}
}

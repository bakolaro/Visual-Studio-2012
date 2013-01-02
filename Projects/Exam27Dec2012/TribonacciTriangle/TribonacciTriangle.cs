using System;
class TribonacciTriangle
{
	static void Main()
	{
		string firstLine = Console.ReadLine();
		string secondLine = Console.ReadLine();
		string thirdLine = Console.ReadLine();
		string fourthLine = Console.ReadLine();

		int L = int.Parse(fourthLine);
		int count = 0;
		for (int i = 1; i <= L; i++)
		{
			count += i;
		}
		long[] numbers = new long[count];

		numbers[0] = int.Parse(firstLine);
		numbers[1] = int.Parse(secondLine);
		numbers[2] = int.Parse(thirdLine);

		for (int i = 3; i < count; i++)
		{
			numbers[i] = numbers[i - 1] + numbers[i - 2] + numbers[i - 3];
		}
		int counter = 0;
		for (int i = 1; i <= L; i++)
		{
			for (int j = 0; j < i - 1; j++)
			{
				Console.Write("{0} ", numbers[counter++]);
			}
			Console.WriteLine("{0}", numbers[counter++]);
		}
	}
}

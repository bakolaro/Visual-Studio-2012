using System;

class NextDate
{
	static void Main()
	{
		int day = int.Parse(Console.ReadLine());
		int month = int.Parse(Console.ReadLine());
		int year = int.Parse(Console.ReadLine());
		DateTime nextDate = new DateTime(year, month, day);
		Console.WriteLine("{0:d.M.yyyy}", nextDate.AddDays(1.0));
	}
}
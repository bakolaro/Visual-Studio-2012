using System;
using IntroCSharp;

class Chapter02
{
	public static void Run ()
	{
      object someNumber = "234";
      Console.WriteLine("string = " + someNumber); // 234
      someNumber = 234;
      Console.WriteLine("int = " + someNumber); // 234
      someNumber = 234L;
      Console.WriteLine("long = " + someNumber); // 234
      someNumber = 234uL;
      Console.WriteLine("unsigned long = " + someNumber); // 234
      someNumber = 0xea;
      Console.WriteLine("hexadecimal int = " + someNumber); // 234
      someNumber = 0xeau;
      Console.WriteLine("unsigned hexadecimal int = " + someNumber); // 234

      object[] values = {
			(int)52130,
			(sbyte)-115,
			(int)4825932,
			(sbyte)97,
			(short)-10000,
			(short)20000,
			(byte)224,
			(int)970700000,
			(sbyte)112,
			(sbyte)-44,
			(int)-1000000,
			(short)1990,
			(long)123456789123456789L,
			34.567839023f,
			12.345f,
			8923.1234857f,
			3456.091124875956542151256683467f,
			34.567839023,
			12.345,
			8923.1234857,
			3456.091124875956542151256683467,
			34.567839023m,
			12.345m,
			8923.1234857m,
			3456.091124875956542151256683467m,
			0x100,
			0x48,
			"\u0048"
		};
		string[] literals = {
			"(int)52130",
			"(sbyte)-115",
			"(int)4825932",
			"(sbyte)97",
			"(short)-10000",
			"(short)20000",
			"(byte)224",
			"(int)970700000",
			"(sbyte)112",
			"(sbyte)-44",
			"(int)-1000000",
			"(short)1990",
			"(long)123456789123456789L",
			"34.567839023f",
			"12.345f",
			"8923.1234857f",
			"3456.091124875956542151256683467f",
			"34.567839023",
			"12.345",
			"8923.1234857",
			"3456.091124875956542151256683467",
			"34.567839023m",
			"12.345m",
			"8923.1234857m",
			"3456.091124875956542151256683467m",
			"0x100",
			"0x48",
			@"\u0048"
		};
		for (int i = 0; i < values.Length; i++) {
			Console.WriteLine (
				"Expression "
				+ literals [i]
				+ " equals "
			   	+ values [i]
				+ " of type "
				+ values [i].GetType ()
			);
		}
		bool isMale = true;
		if (isMale)
			Console.WriteLine ("Male");
		else
			Console.WriteLine ("Female");
		string hello = "Hello";
		string world = "world";
		object helloWorld = hello + " " + world;
		Console.WriteLine (helloWorld);
		string hi = (string)helloWorld;
		Console.WriteLine (hi);
		string quot = @"The ""use"" of quotations causes difficulties.";
		string esc = "The \"use\" of quotations causes difficulties.";
		Console.WriteLine (quot);
		Console.WriteLine (esc);
		
		WriteHeart ();
		WriteTriangle (9);
		/*
     * string firstName, lastName;
		byte age;
		char sex;
		int pid;
		       */
		int a, b, tmp;
		a = 5; b = 10;
		tmp = a;
		a = b;
		b = tmp;
		Console.WriteLine ("a = " + a);
		Console.WriteLine ("b = " + b);
	}

	public static bool InCircleAwayFromCenter (double x, double y,
		double xCenter, double yCenter, double radius, double xOffset, double yOffset)
	{
		return
			((x - xCenter) * (x - xCenter) +
			 (y - yCenter) * (y - yCenter) < radius * radius) &&
				(x / xOffset > xCenter / xOffset + 1) &&
				(y / yOffset > yCenter / yOffset + 1);
	}

	public static void WriteHeart ()
	{
		Console.WriteLine ("______________________________________");
		Console.WriteLine ("________oooooo__________oooooo________");
		Console.WriteLine ("_____ooooooooooo______ooooooooooo_____");
		Console.WriteLine ("___ooooooooooooooo__ooooooooooooooo___");
		Console.WriteLine ("_oooooooooooooooooooooooooooooooooooo_");
		Console.WriteLine ("_oooooooooooooooooooooooooooooooooooo_");
		Console.WriteLine ("__oooooooooooooooooooooooooooooooooo__");
		Console.WriteLine ("___oooooooooooooooooooooooooooooooo___");
		Console.WriteLine ("_____oooooooooooooooooooooooooooo_____");
		Console.WriteLine ("______oooooooooooooooooooooooooo______");
		Console.WriteLine ("_______oooooooooooooooooooooooo_______");
		Console.WriteLine ("________oooooooooooooooooooooo________");
		Console.WriteLine ("__________oooooooooooooooooo__________");
		Console.WriteLine ("___________oooooooooooooooo___________");
		Console.WriteLine ("____________oooooooooooooo____________");
		Console.WriteLine ("_____________oooooooooooo_____________");
		Console.WriteLine ("_______________oooooooo_______________");
		Console.WriteLine ("________________oooooo________________");
		Console.WriteLine ("__________________oo__________________");
		Console.WriteLine ("______________________________________");
	}
	public static void WriteTriangle (int baseLength)
	{
		char symb = '\u00A9';
		string blank = "__";
		int i;
		for (int nRow = 0; nRow < baseLength; nRow++)
		{
			i = (nRow < baseLength / 2) ? nRow : baseLength - nRow - 1;
			Console.Write (symb);
			for (int j = 0; j < i - 1; j++)
			{
				Console.Write (blank);
			}
			if (i > 0)
				Console.Write (symb);
			Console.WriteLine ();
		}
	}
}
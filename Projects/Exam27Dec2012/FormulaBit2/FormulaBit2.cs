using System;

class FormulaBit2
{
	static void Main()
	{
		int[] n = new int[8];
		for (int index = 0; index < 8; index++)
		{
			n[index] = int.Parse(Console.ReadLine());
		}

		int X = 0, Y = 0; // Moves, Truns
		bool built = false;
		int i = 0, j = 0; // Current coordinates
		bool south = true, west = false, north = false;
		bool southPrev = false, westPrev = true, northPrev = false;
		do
		{
			bool canMoveSouth = (i < 7) && (((n[i + 1] >> j) & 1) == 0);
			bool canMoveWest = (j < 7) && (((n[i] >> (j + 1)) & 1) == 0);
			bool canMoveNorth = (i > 0) && (((n[i - 1] >> j) & 1) == 0);

			if ((i == 0) && (j == 0) && ((n[i] & 1) == 1))
			{
				break;
			}
						
			if ((i == 7) && (j == 7))
			{
				X++;
				built = true;
			}
			else if (south && canMoveSouth)
			{
				i++;
				X++;
			}
			else if (west && canMoveWest)
			{
				j++;
				X++;
			}
			else if (north && canMoveNorth)
			{
				i--;
				X++;
			}
			else if (west && northPrev && canMoveSouth)
			{
				south = true; west = false; north = false;
				i++;
				X++;
				Y++;
			}
			else if (canMoveWest)
			{
				southPrev = south; westPrev = west; northPrev = north;
				south = false; west = true; north = false;
				j++;
				X++;
				Y++;
			}
			else if (west && southPrev && canMoveNorth)
			{
				south = false; west = false; north = true;
				i--;
				X++;
				Y++;
			}
			else
			{
				X++;
				break; // cannot be built
			}
			// Console.WriteLine("[{0}, {1}] = [{2}, {3}] ({4})", i, j, X, Y, built);
		}
		while (!built);


		if (built)
		{
			Console.WriteLine("{0} {1}", X, Y);
		}
		else
		{
			Console.WriteLine("{0} {1}", "No", X);
		}
	}
}


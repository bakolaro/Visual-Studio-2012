using System;

class Program
{
    static void Main()
    {
        // Input data
        int n = int.Parse(Console.ReadLine());
        // Output data
        int outerSpaceLength = n;
        int innerSpaceLength = n - 2;
        char spaceChar = '.';
        char borderChar = '*';
        string outerSpace, innerSpace;
        for (int i = 0; i < n + 1; i++)
        {
            outerSpace = new string(spaceChar, outerSpaceLength);
            if (i == 0 || i == n)
            {
                innerSpace = new string(borderChar, innerSpaceLength);
            }
            else
            {
                innerSpace = new string(spaceChar, innerSpaceLength);
            }
            Console.WriteLine(outerSpace + borderChar + innerSpace + borderChar);
            outerSpaceLength--;
            innerSpaceLength++;
        }
    }
}

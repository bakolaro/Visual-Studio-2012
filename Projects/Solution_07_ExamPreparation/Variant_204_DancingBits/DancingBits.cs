using System;
using System.Text;

class DancingBits
{
    static void Main()
    {
        // Input data
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        StringBuilder sb = new StringBuilder(25600);
        for (int i = 0; i < n; i++)
		{
            a[i] = int.Parse(Console.ReadLine());
            sb.Append(Convert.ToString(a[i], 2));
		}
        // Calculate
        string s = sb.ToString();
        string zeros = new string('0', k);
        string ones = new string('1', k);

        int dancingBitSequences = 0;
        int bitSequenceLength = 1;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i - 1] == s[i])
            {
                bitSequenceLength++;
            }
            else
            {
                if (bitSequenceLength == k)
                {
                    dancingBitSequences++;
                }
                bitSequenceLength = 1;
            }
        }
        if (bitSequenceLength == k)
        {
            dancingBitSequences++;
        }
        // Output data
        Console.WriteLine(dancingBitSequences);
    }
}
using System;

public class QuickSortStrings
{
    public static void Main()
    {
        int[] a = {2, 4, -4, -4, 1000, 10, 203, 1, 10, 16, -1, 0, 1, -4};
        WriteColumn<int>(a);
        Sort(a, 0, a.Length - 1);
        WriteColumn<int>(a);
        string[] b = {"two", "(~)", "extra", "{|}", "super", "Zero", "LCD",
            "23rd", "WWW", "Web-site", "LCD", "[.]", "One", "extra", "ON AIR", "one"};
        WriteColumn<string>(b);
        Sort(b, 0, b.Length - 1);
        WriteColumn<string>(b);
    }
    public static int CompareStrings(string x, string y)
    {
        char[] a = x.ToLower().ToCharArray();
        char[] b = y.ToLower().ToCharArray();
        int i = 0;
        while (i < a.Length && i < b.Length)
        {
            if (a[i].CompareTo(b[i]) < 0)
            {
                return -1;
            }
            else if (a[i].CompareTo(b[i]) > 0)
            {
                return 1;
            }
            i++;
        }
        if (a.Length < b.Length)
        {
            return -1;
        }
        else if (a.Length > b.Length)
        {
            return 1;
        }
        return 0;
    }
    public static void Sort(int[] matrix, int start, int end)
    {
        if (start < end)
        {
            int pivot = start + (end - start) / 2;
            int i = start;
            int j = end;

            while (i < j)
            {
                while (i < pivot && matrix[i] <= matrix[pivot])
                {
                    i++;
                }
                while (j > pivot && matrix[j] >= matrix[pivot])
                {
                    j--;
                }
                if (i < j)
                {
                    int swap = matrix[i];
                    matrix[i] = matrix[j];
                    matrix[j] = swap;
                    if (j == pivot)
                    {
                        j = end;
                        i++;
                    }
                    else if (i == pivot)
                    {
                        i = start;
                        j--;
                    }
                    else
                    {
                        i++;
                        j--;
                    }
                }
            }
            Sort(matrix, start, pivot - 1);
            Sort(matrix, pivot + 1, end);
        }
    }
    public static void Sort(string[] matrix, int start, int end)
    {
        if (start < end)
        {
            int pivot = start + (end - start) / 2;
            int i = start;
            int j = end;

            while (i < j)
            {
                while (i < pivot && CompareStrings(matrix[i], matrix[pivot]) < 1)
                {
                    i++;
                }
                while (j > pivot && CompareStrings(matrix[j], matrix[pivot]) > -1)
                {
                    j--;
                }
                if (i < j)
                {
                    string swap = matrix[i];
                    matrix[i] = matrix[j];
                    matrix[j] = swap;
                    if (j == pivot)
                    {
                        j = end;
                        i++;
                    }
                    else if (i == pivot)
                    {
                        i = start;
                        j--;
                    }
                    else
                    {
                        i++;
                        j--;
                    }
                }
            }
            Sort(matrix, start, pivot - 1);
            Sort(matrix, pivot + 1, end);
        }
    }
    public static void WriteColumn<T>(T[] matrix)
    {
        foreach (T i in matrix)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }
}

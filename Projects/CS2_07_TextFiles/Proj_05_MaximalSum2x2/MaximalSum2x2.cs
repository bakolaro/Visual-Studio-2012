using System;
using System.Text;
using System.IO;
using System.Threading;
using System.Globalization;

class MaximalSum2x2
{
    /* Write a program that reads a text file containing a square
     * matrix of numbers and finds in the matrix an area of 
     * size 2 x 2 with a maximal sum of its elements. The first
     * line in the input file contains the size of matrix N. Each 
     * of the next N lines contain N numbers separated by space. 
     * The output should be a single number in a separate text file.
     */
    static void Main()
    {
        double maxSum = double.NegativeInfinity;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Encoding enc = Encoding.GetEncoding(1251);
        StreamReader inStream = new StreamReader("SquareMatrix.in", enc);
        using (inStream)
        {
            string line = inStream.ReadLine();
            int n = int.Parse(line);
            double[,] matrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] numbers = inStream.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = double.Parse(numbers[j]);
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    double localSum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
                    if (localSum > maxSum)
                    {
                        maxSum = localSum;
                    }
                }
            }
        }
        StreamWriter outStream = new StreamWriter("SquareMatrix.out", false, enc);
        using (outStream)
        {
            outStream.WriteLine(maxSum);
        }
        Console.WriteLine("Maximal sum of a 2 x 2 submatrix = {0}", maxSum);
    }
}
using System;
using System.IO;

namespace MultidimensionalArrays
{
    public class TestClassMaxSumSubmatrix3x3
    {
        public static void Main()
        {
            // Redirect IO
            StreamReader reader = new StreamReader("TestInput001.txt");
            Console.SetIn(reader);
            StreamWriter writer = new StreamWriter("TestOutput001.txt");
            Console.SetOut(writer);

            MaxSumSubmatrix3x3.Main();

            // Set input and output to standart IO streams
            writer.Close();
            Console.OpenStandardOutput();
            reader.Close();
            Console.OpenStandardInput();
        }
    }
}

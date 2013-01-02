using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

class PHPVariables
{
    static void Main()
    {
        List<string> input = new List<string>();
        string inputLine;
        
        //StreamReader reader = new StreamReader("Test0.php");
        //Console.SetIn(reader);
        do
        {
            inputLine = Console.ReadLine();
            input.Add(inputLine);
        }
        while (!inputLine.Equals("?>"));
        //reader.Close();

        bool insideArray, insideString, insideComment;
        insideArray = insideComment = insideString = false;
        StringBuilder nextVariableName = new StringBuilder(1000000);
        SortedSet<string> dictionary = new SortedSet<string>();

        bool[] insideVariable = new bool[3];
        foreach (string line in input)
        {
            foreach (char symbol in line)
            {
                
                if (insideVariable[1])
                {
                    if (symbol == '_'
                    || (symbol >= 65 && symbol <= 90)
                    || (symbol >= 97 && symbol <= 122)
                    || (symbol >= 48 && symbol <= 57)) // digits
                    {
                        insideVariable[2] = true;
                        nextVariableName.Append(symbol);
                    }
                    else
                    {
                        insideVariable[0] = false;
                        insideVariable[1] = false;
                        insideVariable[2] = false;
                        dictionary.Add(nextVariableName.ToString());
                        nextVariableName.Clear();
                    }
                }
                if (insideVariable[0]
                    && (symbol == '_' // underscore
                    || (symbol >= 65 && symbol <= 90) // capital letters
                    || (symbol >= 97 && symbol <= 122))) // small letters
                {
                    insideVariable[0] = false;
                    insideVariable[1] = true;
                    nextVariableName.Append(symbol);
                }
                if (symbol == '$')
                {
                    insideVariable[0] = true; // dollar sign
                    nextVariableName.Clear();
                }
            }
        }

        Console.WriteLine(dictionary.Count);
        foreach (var item in dictionary)
        {
            Console.WriteLine(item);
        }
        /*
        StreamWriter writer = new StreamWriter("TestOutput001.txt");
        Console.SetOut(writer);
        foreach (string line in input)
        {
            Console.WriteLine(line);
        }
        writer.Close();
        */
    }
}

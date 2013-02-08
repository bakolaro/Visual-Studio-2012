/*
Problem 3 - Employees
MCPF has M employees with N different positions. Each position has a rating (number 
indicating how important the position is in the company's hierarchy). This rating will be 
positive integer number between 0 and 10000, inclusive.
Your task is to write a program that orders employees by their position. If two 
employees' positions are equally rated, then your program should order them lexicographically 
by their last (family) name. And if two employees have equally rated positions and same family 
names, your program must also sort them by their first name lexicographically.
Input
The input data should be read from the console.
On the first line there will be the number N - the total number of positions in MCPF. On each 
of the next N lines there will be one job title and its rating, separated by dash ("-"). See the example below.
On the very next line there will be the number M - the total number of employees in MCPF. On each of the 
next M lines there you will find one employee's name (first name and last name separated by single space) 
and the employee's position. The employee's name and his position will be separated by dash ("-"). See the example below.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
Your program must print exactly M lines, containing the employee's names, ordered by the rules 
explained above. Each name must be shown on a single line.
Constraints
- N will be between 1 and 1000, inclusive.
- M will be between 1 and 1000, inclusive.
- The length of all position names, first and last names will be between 1 and 100, inclusive.
- Allowed working time for your program: 0.1 seconds.
- Allowed memory: 16 MB.
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class Ranks
{
    public Dictionary<string, int> Jobs;
    public Ranks(int positions)
    {
        Jobs = new Dictionary<string, int>(positions);
        for (int i = 0; i < positions; i++)
        {
            string line = Console.ReadLine();
            int last = Math.Max(line.LastIndexOf('-'), Math.Max(line.LastIndexOf('–'), line.LastIndexOf('—')));
            string position = line.Substring(0, last).Trim();
            string rank = line.Substring(last + 1).Trim();
            Jobs.Add(position, int.Parse(rank));
        }
    }
    public Ranks(string file)
    {
        string[] lines = File.ReadAllLines(file);
        int positions = lines.Length;
        Jobs = new Dictionary<string, int>(positions);
        for (int i = 0; i < positions; i++)
        {
            int last = Math.Max(lines[i].LastIndexOf('-'), Math.Max(lines[i].LastIndexOf('–'), lines[i].LastIndexOf('—')));
            string position = lines[i].Substring(0, last).Trim();
            string rank = lines[i].Substring(last + 1).Trim();
            Jobs.Add(position, int.Parse(rank));
        }
    }
    public void Print()
    {
        foreach (KeyValuePair<string, int> pair in Jobs)
        {
            Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
        }
    }
}

public class Employee : IComparable
{
    public string FirstName, LastName, Position;
    public int Rank;
    public Employee(string line, Ranks ranks)
    {
        int last = Math.Max(line.LastIndexOf('-'), Math.Max(line.LastIndexOf('–'), line.LastIndexOf('—')));
        string fullName = line.Substring(0, last).Trim();
        string Position = line.Substring(last + 1).Trim();
        string[] names = fullName.Split();
        FirstName = names[0];
        LastName = names[1];
        Rank = ranks.Jobs[Position];
    }
    public void Print(bool namesOnly = true)
    {
        if (namesOnly)
        {
            Console.WriteLine("{0} {1}", FirstName, LastName);
        }
        else
        {
            Console.WriteLine("{0} {1} - {2} ({3})", FirstName, LastName, Position, Rank);
        }
    }
    public int CompareTo(object obj)
    {
        Employee employee = (Employee)obj;
        if (Rank < employee.Rank)
        {
            return 1;
        }
        else if (Rank > employee.Rank)
        {
            return -1;
        }
        else if (LastName.CompareTo(employee.LastName) < 0)
        {
            return -1;
        }
        else if (LastName.CompareTo(employee.LastName) > 0)
        {
            return 1;
        }
        else if (FirstName.CompareTo(employee.FirstName) < 0)
        {
            return -1;
        }
        else if (FirstName.CompareTo(employee.FirstName) > 0)
        {
            return 1;
        }
        return 0;
    }
}

public class Employees
{
    public Employee[] Staff;
    public Employees(int positions, Ranks ranks)
    {
        Staff = new Employee[positions];
        for (int i = 0; i < positions; i++)
        {
            Staff[i] = new Employee(Console.ReadLine(), ranks);
        }
    }
    public Employees(string file, Ranks ranks)
    {
        string[] lines = File.ReadAllLines(file);
        int positions = lines.Length;
        Staff = new Employee[positions];
        for (int i = 0; i < positions; i++)
        {
            Staff[i] = new Employee(lines[i], ranks);
        }
    }
    public void Print(bool namesOnly = true)
    {
        for (int i = 0; i < Staff.Length; i++)
        {
            Staff[i].Print(namesOnly);
        }
    }
    public static void Main()
    {
        //Ranks jobs = new Ranks("Ranks.in");

        int n = int.Parse(Console.ReadLine());
        Ranks jobs = new Ranks(n);

        //Employees staff = new Employees("Employees.in", jobs);
        int m = int.Parse(Console.ReadLine());
        Employees staff = new Employees(m, jobs);
        Array.Sort(staff.Staff);
        staff.Print();
    }
}
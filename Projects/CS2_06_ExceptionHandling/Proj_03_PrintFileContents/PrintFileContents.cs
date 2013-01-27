using System;
using System.IO;
using System.Text;
using System.Security;

class PrintFileContents
{
    /* Write a program that enters file name along with its full file
     * path (e.g. C:\WINDOWS\win.ini), reads its contents and prints
     * it on the console. Find in MSDN how to use
     * System.IO.File.ReadAllText(…). Be sure to catch all possible
     * exceptions and print user-friendly error messages.
     */
    static void Main()
    {
        Encoding enc = Encoding.GetEncoding(1251); 
        //string path = Console.ReadLine();
        string[] pathStrings = { ""
                                   , @"C:\"
                                   , @"C:\Users\R\Documents\desktop.ini"
                                   , @"C:\Users\R\Documents\ThereIsNoSuchFile.txt"
                                   , @"Invalid|File|Name|On|Some|Platforms.txt"
                                   , @"        " // space
                                   , null
                                   , @"1234567890_1234567890_1234567890_1234567890_1234567890~1234567890_1234567890_1234567890_1234567890_1234567890~1234567890_1234567890_1234567890_1234567890_1234567890~1234567890_1234567890_1234567890_1234567890_1234567890~1234567890_1234567890_1234567890_1234567890_1234567890.txt"
                                   , @"NewLineCharacters
AreNotValidFileNameCharacters.txt"
                               };
        foreach (string str in pathStrings)
        {
            PrintFile(str, enc);
        }
    }
    public static void PrintFile(string path, Encoding enc)
    {
        Console.WriteLine("Path and file name: '{0}'", path);
        try
        {
            string text = File.ReadAllText(path, enc);
            Console.WriteLine("File contents:");
            Console.WriteLine(new string('.', 50));
            Console.WriteLine(text);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
            Console.WriteLine("Path is null.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
            Console.WriteLine(@"Possible causes for this exception include:
Path is a zero-length string,
contains only white space,
or contains one or more invalid characters as defined by InvalidPathChars.");
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
            Console.WriteLine(@"Possible causes for this exception include:
The specified path, file name, or both exceed the system-defined maximum
length. For example, on Windows-based platforms, paths must be less than 248
characters, and file names must be less than 260 characters.");
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
            Console.WriteLine(@"Possible causes for this exception include:
The specified path is invalid (for example, it is on an unmapped drive).");
        }
        catch (SecurityException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
            Console.WriteLine(@"Possible causes for this exception include:
The caller does not have the required permission.");
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
            Console.WriteLine(@"Possible causes for this exception include:
Path specified a file that is read-only
or this operation is not supported on the current platform
or path specified a directory.");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
            Console.WriteLine(@"Possible causes for this exception include:
The file specified in path was not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
            Console.WriteLine(@"Possible causes for this exception include:
An I/O error occurred while opening the file.");
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
            Console.WriteLine(@"Possible causes for this exception include:
Path is in an invalid format.");
        }
        finally
        {
            Console.WriteLine(new string('_', 70));
        }
    }
}
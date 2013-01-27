using System;
using System.Net;
using System.IO;

class DownloadFileFromWeb
{
    /* Write a program that downloads a file from 
     * Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and 
     * stores it the current directory. Find in Google how to 
     * download files in C#. Be sure to catch all exceptions and 
     * to free any used resources in the finally block.
     */
    static void Main()
    {
        string[] pathStrings = { ""
                                   , @"http://www.devbg.org/img/Logo-BASD-001.jpg"
                                   , @"http://www.devbg.org/img/Logo-BASD.jpg"
                                   , @"http://www.Invalid|File|Name|On|The|Web.html"
                                   , null
                                   , @"1234567890_1234567890_1234567890_1234567890_1234567890~1234567890_1234567890_1234567890_1234567890_1234567890~1234567890_1234567890_1234567890_1234567890_1234567890~1234567890_1234567890_1234567890_1234567890_1234567890~1234567890_1234567890_1234567890_1234567890_1234567890.txt"
                                   , @"NewLineCharacters
AreNotValidURLCharacters.txt"
                               };
        foreach (string str in pathStrings)
        {
            Download(str);
        }
    }
    public static void Download(string url)
    {
        Console.WriteLine("URL: '{0}'", url);
        try
        {
            string[] path = url.Split('/');
            string file = path[path.Length - 1];
            Console.WriteLine(file);
            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, file);
            Console.WriteLine("File {0} was downloaded successfully.", file);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
            Console.WriteLine("The address parameter is null.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
        }
        catch (WebException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine("Error message: " + ex.Message);
        }
        finally
        {
            Console.WriteLine(new string('_', 70));
        }
    }
}
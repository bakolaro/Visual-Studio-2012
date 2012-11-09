using System;

class CompanyInfo
{
    static void Main()
    {
        // A company has name, address, phone number, fax number, web site and manager. 
        // The manager has first name, last name, age and a phone number. Write a program 
        // that reads the information about a company and its manager and prints them on the console.

        // About
        Console.WriteLine("Company Information");
        // Input data
        Console.Write("Name = ");
        string name = Console.ReadLine();
        Console.Write("Address = ");
        string address = Console.ReadLine();
        Console.Write("Phone = ");
        string phone = Console.ReadLine();
        Console.Write("Fax = ");
        string fax = Console.ReadLine();
        Console.Write("Web site = ");
        string webSite = Console.ReadLine();
        Console.Write("Manager, first name = ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager, last name = ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager, age = ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager, phone = ");
        string managerPhone = Console.ReadLine();
        // Ouput data
        Console.WriteLine("Company: {0}", name);
        Console.WriteLine("Address: {0}", address);
        Console.WriteLine("Phone: {0}; Fax: {1}", phone, fax);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1}, {2}", managerFirstName, managerLastName, managerAge);
        Console.WriteLine("Phone: {0}", managerPhone);
    }
}

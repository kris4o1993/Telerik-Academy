using System;

//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager and prints them on the console.

class CompanyInfo
{
    static void Main()
    {
        Console.Write("Enter company's name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company's address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter company's phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Enter company's fax: ");
        string companyFax = Console.ReadLine();
        Console.Write("Enter company's web site: ");
        string companySite = Console.ReadLine();
        Console.Write("Enter manager's first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager's last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter manager's age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Enter manager's phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("COMPANY INFORMATION:");
        Console.WriteLine("Name: " + companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Phone: " + companyPhone);
        Console.WriteLine("Fax: " + companyFax);
        Console.WriteLine("Website: " + companySite);
        Console.WriteLine();
        Console.WriteLine("MANAGER INFORMATION:");
        Console.WriteLine("Name: {0} {1}", managerFirstName, managerLastName);
        Console.WriteLine("Age: " + managerAge);
        Console.WriteLine("Phone: " + managerPhone);
    }
}

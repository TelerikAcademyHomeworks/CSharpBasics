using System;

//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Please enter company name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Please enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Please enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Please enter fax number: ");
        int faxNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter website: ");
        string website = Console.ReadLine();
        Console.WriteLine("Please enter manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Please enter manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("Please enter manager's age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Please enter manager's phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        Console.WriteLine("Fax: {0}", faxNumber);
        Console.WriteLine("WebSite: {0}", website);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", 
            managerFirstName, managerLastName, age, managerPhone);
    }
}


using System;
using System.Text;

//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        long number = long.Parse(Console.ReadLine());

        long reminder;
        int index = 0;
        StringBuilder binaryRepresentatiopn = new StringBuilder();

        while (number > 0)
        {
            reminder = number%2;
            number /= 2;

            binaryRepresentatiopn.Insert(index, reminder);
            index++;
        }

        Console.WriteLine("{0}", binaryRepresentatiopn.ToString().PadLeft(64, '0'));
    }
}


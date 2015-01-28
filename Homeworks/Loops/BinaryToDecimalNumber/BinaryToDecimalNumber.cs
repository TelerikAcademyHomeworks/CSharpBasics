using System;

//Problem 13. Binary to Decimal Number

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter number in binary form: ");
        string binaryString = Console.ReadLine();

        long numberInDec = 0;

        for (int i = binaryString.Length - 1, j = 0; i >= 0; i--, j++)
        {
            numberInDec += (long)Math.Pow(2, j) * long.Parse(binaryString[i].ToString());
        }

        Console.WriteLine(numberInDec);
    }
}


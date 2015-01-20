using System;

//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("Please enter number: ");
        string inputString = Console.ReadLine();
        int InitialNumber = int.Parse(inputString);

        int number;
        number = InitialNumber % 1000;

        if (number / 100 == 7)
        {
            Console.WriteLine("Third digit of number {0} is 7", InitialNumber);
        }
        else
        {
            Console.WriteLine("Third digit of number {0} is not 7", InitialNumber);
        }
    }
}


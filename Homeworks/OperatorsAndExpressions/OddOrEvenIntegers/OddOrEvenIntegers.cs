using System;

//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.

class OddOrEvenIntegers
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        int number = int.Parse(inputString);

        if (number % 2 == 0)
        {
            Console.WriteLine("Number {0} is even!", number);
        }
        else
        {
            Console.WriteLine("Number {0} is odd", number);
        }
    }
}


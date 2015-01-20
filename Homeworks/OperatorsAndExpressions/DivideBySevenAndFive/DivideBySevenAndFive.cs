using System;

//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.WriteLine("Please enter numebr: ");

        string inputString = Console.ReadLine();
        int number = int.Parse(inputString);

        bool isDivideBySevenAndFive = (number%7 == 0) && (number%5 == 0);

        if (isDivideBySevenAndFive)
        {
            Console.WriteLine("The number {0}, is divided by 7 and 5 and the samo time!", number);
        }
        else
        {
            Console.WriteLine("The number can not be divide by seven and five without reminder at the same time!");
        }
    }
}


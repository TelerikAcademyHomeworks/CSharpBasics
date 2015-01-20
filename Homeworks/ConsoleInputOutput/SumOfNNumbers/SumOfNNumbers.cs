using System;

//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

class SumOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter the number of numbers you want to enter");
        int numbers = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 1; i <= numbers; i++)
        {
            Console.WriteLine("Please enter {0} number", i);
            sum += double.Parse(Console.ReadLine());
        }

        Console.WriteLine("The sum of the numbers is: {0}", sum);
    }
}


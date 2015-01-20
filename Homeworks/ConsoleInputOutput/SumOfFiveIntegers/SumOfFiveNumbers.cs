using System;

//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

class SumOfFiveNumbers
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        string[] numbersStrings = inputString.Split(' ');
        double[] numbers = new double[numbersStrings.Length];

        for (int i = 0; i < numbersStrings.Length; i++)
        {
            numbers[i] = double.Parse(numbersStrings[i]);
        }

        double sum = 0;

        foreach (var number in numbers)
        {
            sum += number;
        }

        Console.WriteLine("Sum of the numbers is: {0}", sum);
    }
}


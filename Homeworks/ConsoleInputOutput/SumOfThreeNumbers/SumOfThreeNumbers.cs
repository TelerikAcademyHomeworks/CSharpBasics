using System;

//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.
using System.Data.Odbc;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number: ");
        double thirdNUm = double.Parse(Console.ReadLine());

        double sumOfNumbers = firstNum + secondNum + thirdNUm;

        Console.WriteLine("The sum of the three number you enterd is: {0}", sumOfNumbers);
    }
}


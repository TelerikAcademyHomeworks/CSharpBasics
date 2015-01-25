using System;

//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Please enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());

        if (firstNum > secondNum)
        {
            double container = firstNum;
            firstNum = secondNum;
            secondNum = container;
        }

        Console.WriteLine("{0} {1}", firstNum, secondNum);
    }
}


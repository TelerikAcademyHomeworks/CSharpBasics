using System;

//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter third number: ");
        double thirdNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter forth number: ");
        double forthNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter fifth number: ");
        double fifthNum = double.Parse(Console.ReadLine());

        double biggestNum;

        if (firstNum > secondNum && firstNum > thirdNum && firstNum > forthNum && firstNum > fifthNum)
        {
            biggestNum = firstNum;
        }
        else if (secondNum > thirdNum && secondNum > forthNum && secondNum > fifthNum)
        {
            biggestNum = secondNum;
        }
        else if (thirdNum > forthNum && thirdNum > fifthNum)
        {
            biggestNum = thirdNum;
        }
        else if (forthNum > fifthNum)
        {
            biggestNum = forthNum;
        }
        else
        {
            biggestNum = fifthNum;
        }

        Console.WriteLine(biggestNum);
    }
}


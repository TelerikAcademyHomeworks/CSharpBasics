using System;

//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter third number: ");
        double thirdNum = double.Parse(Console.ReadLine());

        //if (firstNum >= secondNum)
        //{
        //    if (thirdNum >= firstNum)
        //    {
        //        Console.WriteLine(thirdNum);
        //    }
        //    else
        //    {
        //        Console.WriteLine(firstNum);
        //    }
        //}
        //else
        //{
        //    if (thirdNum >= secondNum)
        //    {
        //        Console.WriteLine(thirdNum);
        //    }
        //    else
        //    {
        //        Console.WriteLine(secondNum);
        //    }
        //}

        double biggestNumber = 0;
        biggestNumber = firstNum > secondNum ? firstNum : secondNum;
        biggestNumber = biggestNumber > thirdNum ? biggestNumber : thirdNum;

        Console.WriteLine(biggestNumber);
    }
}


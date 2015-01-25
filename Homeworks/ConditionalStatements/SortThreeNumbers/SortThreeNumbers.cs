using System;

//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

class SortThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter third number: ");
        double thirdNum = double.Parse(Console.ReadLine());

        double biggestNum = 0;
        double middleNum = 0;
        double smallestNum = 0;

        if (firstNum >= secondNum)
        {
            if (firstNum >= thirdNum)
            {
                biggestNum = firstNum;

                if (secondNum >= thirdNum)
                {
                    middleNum = secondNum;
                    smallestNum = thirdNum;
                }
                else
                {
                    middleNum = thirdNum;
                    smallestNum = secondNum;
                }
            }
            else
            {
                biggestNum = thirdNum;
                middleNum = firstNum;
                smallestNum = secondNum;
            }
        }
        else
        {
            if (secondNum >= thirdNum)
            {
                biggestNum = secondNum;

                if (firstNum >= thirdNum)
                {
                    middleNum = firstNum;
                    smallestNum = secondNum;
                }
                else
                {
                    middleNum = thirdNum;
                    smallestNum = firstNum;
                }
            }
            else
            {
                biggestNum = thirdNum;
                middleNum = secondNum;
                smallestNum = firstNum;
            }
        }

        Console.WriteLine("{0} {1} {2}", biggestNum, middleNum, smallestNum);
    }
}


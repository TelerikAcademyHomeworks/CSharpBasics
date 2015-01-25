using System;

//Problem 4. Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Please enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter third number: ");
        double thirdNum = double.Parse(Console.ReadLine());

        if (firstNum > 0)
        {
            if (secondNum > 0)
            {
                if (thirdNum > 0)
                {
                    Console.WriteLine("+");
                }
                else if (thirdNum < 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
            else if (secondNum < 0)
            {
                if (thirdNum > 0)
                {
                    Console.WriteLine("-");
                }
                else if (thirdNum < 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
        else if (firstNum < 0)
        {
            if (secondNum > 0)
            {
                if (thirdNum > 0)
                {
                    Console.WriteLine("-");
                }
                else if (thirdNum < 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
            else if (secondNum < 0)
            {
                if (thirdNum > 0)
                {
                    Console.WriteLine("+");
                }
                else if (thirdNum < 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}


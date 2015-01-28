using System;

//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

class CalculateSum
{    

    static void Main()
    {
        Console.WriteLine("Please enter n: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter x: ");
        int x = int.Parse(Console.ReadLine());

        decimal sum = 1;
        decimal factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
            sum += factorial/(decimal)Math.Pow(x, i);
        }

        Console.WriteLine("{0:f5}", sum);
    }
}


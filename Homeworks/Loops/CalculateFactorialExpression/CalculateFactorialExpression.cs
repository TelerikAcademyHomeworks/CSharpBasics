using System;
using  System.Numerics;

//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

class CalculateFactorialExpression
{
    public static BigInteger Factorial(int number)
    {
        if (number == 0) return 1;
        return number * Factorial(number - 1);
    }

    static void Main()
    {
        Console.WriteLine("Please enter k > 1 and k < 100");
        int k;
        int n;

        while (true)
        {
            k = int.Parse(Console.ReadLine());

            if (k >= 1 && k < 100)
            {
                break;
            }

            Console.WriteLine("Please enter k > 1 and k < 100");
        }

        Console.WriteLine("Please enter n < k and n < 100");

        while (true)
        {
            n = int.Parse(Console.ReadLine());

            if (n > k && n < 100)
            {
                break;
            }

            Console.WriteLine("Please enter n < k and n < 100");
        }

        BigInteger nFactorial = Factorial(n);
        BigInteger kFactorial = Factorial(k);
        BigInteger nMinusKFactorial = Factorial(n - k);

        BigInteger result = nFactorial / (kFactorial * nMinusKFactorial);
        Console.WriteLine(result);
    }
}


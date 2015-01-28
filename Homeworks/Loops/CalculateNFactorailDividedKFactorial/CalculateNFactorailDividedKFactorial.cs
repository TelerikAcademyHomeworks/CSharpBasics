using System;

//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

class CalculateNFactorailDividedKFactorial
{
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

        decimal factorial = 1;

        for (int i = k  + 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}


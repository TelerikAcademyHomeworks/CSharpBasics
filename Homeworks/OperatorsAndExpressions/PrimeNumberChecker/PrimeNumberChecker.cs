using System;

//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

class PrimeNumberChecker
{
    static void Main()
    {
        Console.WriteLine("Please enter a number to be prime checked");
        string inputString = Console.ReadLine();
        int number = int.Parse(inputString);

        if (number == 1)
        {
            Console.WriteLine("Number is prime!");
        }
        if (number == 2)
        {
            Console.WriteLine("Number is not prime!");
        }
        if (number == 3)
        {
            Console.WriteLine("Number is prime!");
        }

        if (number < 0)
        {
            Console.WriteLine("Number is not prime");
        }

        bool isPrime = false;

        double minimalDivider = Math.Sqrt(number);

        for (int i = 2; i <= minimalDivider; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine("Number is not prime!");
                break;
            }
            isPrime = true;
        }

        if (isPrime)
        {
            Console.WriteLine("Number is prime");
        }
    }
}


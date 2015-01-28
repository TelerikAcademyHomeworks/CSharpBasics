using System;

//Problem 9. Matrix of Numbers

//Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            for (int j = 1; j <= number; j++)
            {
                Console.Write("{0, -2}", j + i);
            }
            Console.WriteLine();
        }
    }
}


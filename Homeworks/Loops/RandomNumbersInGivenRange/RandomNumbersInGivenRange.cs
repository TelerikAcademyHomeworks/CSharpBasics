using System;

//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Please enter number n: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter min boundry: ");
        int min = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter max boundry: ");
        int max = int.Parse(Console.ReadLine());

        Random rnd = new Random();

        for (int i = 0; i < number; i++)
        {
            Console.Write("{0} ", rnd.Next(min, max + 1));
        }
    }
}


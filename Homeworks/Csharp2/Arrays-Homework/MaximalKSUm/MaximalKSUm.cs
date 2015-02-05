using System;

//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

class MaximalKSUm
{
    static void Main()
    {
        Console.WriteLine("Please enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter m: ");
        int m = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Please enter arr[{0}]", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        for (int i = numbers.Length - m; i < numbers.Length; i++)
        {
            Console.Write(i != numbers.Length - 1 ? numbers[i].ToString() + ", " : numbers[i].ToString());
        }

        Console.WriteLine();
    }
}


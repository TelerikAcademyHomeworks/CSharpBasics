using System;
using System.Linq;

//Problem 12.* Randomize the Numbers 1…N

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

class RandomizeNumbers1ToN
{
    static void Main()
    {
        Console.WriteLine("Please enter n : ");
        int number = int.Parse(Console.ReadLine());

        int[] numbers = new int[number];

        Random rand = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            int randomNumber = rand.Next(1, number + 1);

            while (true)
            {
                if (!numbers.Contains(randomNumber))
                {    
                    break;
                }

                randomNumber = rand.Next(1, number + 1);
            }

            numbers[i] = randomNumber;
        }

        string str = string.Join(" ", numbers);

        Console.WriteLine(str);
    }
}


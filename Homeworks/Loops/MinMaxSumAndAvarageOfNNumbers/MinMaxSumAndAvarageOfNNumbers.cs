using System;

//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

class MinMaxSumAndAvarageOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter n: ");
        int number = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("Please enter {0} number: ", i);
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber < min)
            {
                min = inputNumber;
            }

            if (inputNumber > max)
            {
                max = inputNumber;
            }

            sum += inputNumber;
        }

        Console.WriteLine(min);
        Console.WriteLine(max);
        Console.WriteLine(sum);
        Console.WriteLine("{0:f2}", sum/(double)number);
    }
}


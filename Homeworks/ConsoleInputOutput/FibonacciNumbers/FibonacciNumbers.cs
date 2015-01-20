using System;

//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter number n: ");
        int number = int.Parse(Console.ReadLine());

        int firstMember = 0;
        int secondMember = 1;
        int container = 0;

        if (number == 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.Write("{0}, {1}", firstMember, secondMember);

            for (int i = 2; i < number; i++)
            {
                container = firstMember;
                firstMember = secondMember;
                secondMember = firstMember + container;
                Console.Write(", {0}", secondMember);
            }
            Console.WriteLine();
        }
    }
}


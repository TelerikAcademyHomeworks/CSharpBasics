using System;

//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.
using System.Linq;

class MaximalSequence
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        char[] delimiters = {' ', ','};

        string[] arr = inputString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();

        int maxSeq = 0;
        int currSeq = 1;
        string el = "";

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                currSeq++;
                if (currSeq > maxSeq)
                {
                    maxSeq = currSeq;
                    el = arr[i];
                }
            }
            else
            {
                currSeq = 1;
            }
        }

        for (int i = 0; i < maxSeq; i++)
        {
            Console.Write(i != maxSeq - 1 ? el + ", " : el);
        }

        Console.WriteLine();
    }
}


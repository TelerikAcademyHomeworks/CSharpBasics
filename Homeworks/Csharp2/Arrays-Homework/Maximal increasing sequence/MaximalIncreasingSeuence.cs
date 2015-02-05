using System;
using System.Linq;

//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.

class MaximalIncreasingSeuence
{
    static void Main()
    {
        Console.WriteLine("Please enter numbers with comas between them: ");
        string inputString = Console.ReadLine();
        char[] delimiters = {' ', ','};

        string[] numbersAsStrings = inputString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();

        int maxSeq = 0;
        int curSeq = 1;
        int maxSeqEndIndex = 0;

        for (int i = 0; i < numbersAsStrings.Length - 1; i++)
        {
            if (int.Parse(numbersAsStrings[i + 1]) > int.Parse(numbersAsStrings[i]))
            {
                curSeq++;

                if (curSeq > maxSeq)
                {
                    maxSeq = curSeq;
                    maxSeqEndIndex = i;
                }
            }
            else
            {
                curSeq = 1;
            }
        }

        maxSeqEndIndex++;

        for (int i = maxSeqEndIndex - maxSeq + 1; i <= maxSeqEndIndex; i++)
        {
            Console.Write(i != maxSeqEndIndex? numbersAsStrings[i] + ", " : numbersAsStrings[i]);
        }

        Console.WriteLine();
    }
}


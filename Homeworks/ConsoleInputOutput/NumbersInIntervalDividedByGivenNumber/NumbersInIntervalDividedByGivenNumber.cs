using System;
using System.Collections.Generic;

class NumbersInIntervalDividedByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter the down border of the interval");
        int downBorder = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the up border of the interval");
        int upBorder = int.Parse(Console.ReadLine());

        int count = 0;
        List<int> numbers = new List<int>();

        for (int i = downBorder, j=0 ; i <= upBorder; i++,j++)
        {
            if (i % 5 == 0)
            {
                count++;
                numbers.Add(i);
            }
        }

        Console.WriteLine("There are {0} numbers, in the interval [{1}..{2}] wich are divided by five with reminder 0", count, downBorder, upBorder);

        for (int i = 0; i < count; i++)
        {
            if (i == count - 1)
            {
                Console.Write("{0}", numbers[i]);
                break;
            }
            Console.Write("{0}, ", numbers[i]);
        }

        Console.WriteLine();
    }
}


using System;

//Problem 14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        byte bitPosition;

        Console.WriteLine("Please enter extract bit number between 0 and 31");

        while (true)
        {

            bitPosition = byte.Parse(Console.ReadLine());

            if (bitPosition <= 31)
            {
                break;
            }

            Console.WriteLine("Please enter a number between 0 and 31");
        }

        byte bitValue;

        Console.WriteLine("Please enter value the bit value you want to change");

        while (true)
        {
            bitValue = byte.Parse(Console.ReadLine());
            if (bitValue == 0 || bitValue == 1)
            {
                break;
            }

            Console.WriteLine("Please enter a value for the bit 0 or 1");
        }

        int mask = 1 << bitPosition;
        int changedBitValue = 0;

        if (bitValue == 1)
        {
            changedBitValue = number | mask;
        }
        else
        {
            changedBitValue = number & ~mask;
        }

        Console.WriteLine(changedBitValue);
    }
}


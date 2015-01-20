using System;

//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

class CheckABitAtGivenPosition
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

        int mask = 1 << bitPosition;
        bool isBitOne = ((number & mask) >> bitPosition) == 1;
        Console.WriteLine(isBitOne);
    }
}


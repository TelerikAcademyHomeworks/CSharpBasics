using System;

//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        byte extractBitPosition;

        Console.WriteLine("Please enter extract bit number between 0 and 31");

        while (true)
        {
            
            extractBitPosition = byte.Parse(Console.ReadLine());

            if (extractBitPosition <= 31)
            {
                break;
            }

            Console.WriteLine("Please enter a number between 0 and 31");
        }

        if (extractBitPosition == 31 && number < 0)
        {
            Console.WriteLine("The bit at position {0} of number {1} is 1", extractBitPosition, number);
        }
        else
        {
            int mask = 1 << extractBitPosition;
            int bit = (number & mask) >> extractBitPosition;
            Console.WriteLine("The bit at position {0} of number {1} is {2}", extractBitPosition, number, bit);    
        }
    }
}


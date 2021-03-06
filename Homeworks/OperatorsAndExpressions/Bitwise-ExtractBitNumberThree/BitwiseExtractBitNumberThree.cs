﻿using System;

//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

class BitwiseExtractBitNumberThree
{
    static void Main()
    {
        Console.WriteLine("Please enter a positive number: ");
        uint number = uint.Parse(Console.ReadLine());

        uint mask = 1 << 3;
        uint bit = (number & mask) >> 3;
        Console.WriteLine("The bit of position 3 of the number {0} is {1}", number, bit);
    }
}


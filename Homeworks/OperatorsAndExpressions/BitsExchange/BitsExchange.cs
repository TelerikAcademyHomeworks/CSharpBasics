using System;

//Problem 15.* Bits Exchange

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
using System.Security.Cryptography;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Please enter number n: ");
        uint number = uint.Parse(Console.ReadLine());

        uint mask = number & (uint)117440568;
        Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
        uint changedBitsNumber = number & (~(uint)117440568);
        Console.WriteLine(Convert.ToString(changedBitsNumber, 2).PadLeft(32, '0'));

        changedBitsNumber = changedBitsNumber | (mask << 21);
        Console.WriteLine(Convert.ToString(changedBitsNumber, 2).PadLeft(32, '0'));
        changedBitsNumber = changedBitsNumber | (mask >> 21);
        Console.WriteLine(Convert.ToString(changedBitsNumber, 2).PadLeft(32, '0'));
        Console.WriteLine(changedBitsNumber);
    }
}


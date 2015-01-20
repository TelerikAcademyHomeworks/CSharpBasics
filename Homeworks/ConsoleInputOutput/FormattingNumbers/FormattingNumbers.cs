using System;

//Problem 5. Formatting Numbers

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter first integer number between 0 and 500: ");

        int firstNumber;

        while (true)
        {
            firstNumber = int.Parse(Console.ReadLine());

            if (firstNumber <= 500 && firstNumber >= 0)
            {
                break;
            }

            Console.WriteLine("Please enter first integer number between 0 and 500: ");
        }

        Console.WriteLine("Please enter a floating point number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter a second floating point number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        string formatString = "{0,-10:X}|{1,10}|{2,10:0.00}|{3,-10:f3}|";

        Console.WriteLine(formatString, firstNumber, Convert.ToString(firstNumber, 2).PadLeft(10,'0'), 
            secondNumber, thirdNumber);
    }
}


using System;

//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter a four digit number that cannot start with zero: ");

        string inputString;

        // cheking if the number is with four digits and dont starts with zero
        while (true)
        {
            inputString = Console.ReadLine();
            if (inputString.Length == 4 && int.Parse(inputString) / 1000 != 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a four digit number wich dont start with 0");
            }

        }

        int number = int.Parse(inputString);

        int forthDigit = number%10;
        number /= 10;
        int thirdDigit = number%10;
        number /= 10;
        int secondDigit = number%10;
        number /= 10;
        int firstDigit = number;

        Console.WriteLine("Sum of the digits of the number{0} is {1}", inputString, firstDigit + secondDigit + thirdDigit + forthDigit);

        Console.WriteLine("Number in reversed order is: " + "" + forthDigit + thirdDigit + secondDigit + firstDigit);

        Console.WriteLine("Last number in first position : " + forthDigit + firstDigit + secondDigit + thirdDigit);

        Console.WriteLine("Exchange second and third digits: "+ firstDigit + thirdDigit + secondDigit + forthDigit);
    }
}


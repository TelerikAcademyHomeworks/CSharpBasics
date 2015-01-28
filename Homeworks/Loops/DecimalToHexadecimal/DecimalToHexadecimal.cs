using System;

//Problem 16. Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
using System.Text;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter number in decimal format: ");
        long number = long.Parse(Console.ReadLine());

        
        StringBuilder hexaDecimal = new StringBuilder();
        
        

        while (number > 0)
        {
            int index = 0;
            long reminder = number%16;
            char hexValue = '0';

            if (reminder > 9)
            {
                switch (reminder)
                {
                    case 10:
                        hexValue = 'A';
                        break;
                    case 11:
                        hexValue = 'B';
                        break;
                    case 12:
                        hexValue = 'C';
                        break;
                    case 13:
                        hexValue = 'D';
                        break;
                    case 14:
                        hexValue = 'E';
                        break;
                    case 15:
                        hexValue = 'F';
                        break;
                }

                hexaDecimal.Insert(index, hexValue);
            }
            else
            {
                hexaDecimal.Insert(index, reminder);
            }

            number /= 16;
            index++;
        }

        Console.WriteLine(hexaDecimal);
    }
}


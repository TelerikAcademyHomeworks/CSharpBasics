using System;

//Problem 15. Hexadecimal to Decimal Number

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

class HexaDecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter number in hexadecimal format: ");
        string hexNumber = Console.ReadLine();

        long decimalNumber = 0;
        long coeff = 0;

        for (int i = hexNumber.Length - 1, pow = 0; i >= 0; i--, pow++)
        {
            if (hexNumber[i] >= 65 && hexNumber[i] <= 70)
            {
                switch (hexNumber[i])
                {
                    case 'A':
                        coeff = 10L;
                        break;
                    case 'B':
                        coeff = 11L;
                        break;
                    case 'C':
                        coeff = 12L;
                        break;
                    case 'D':
                        coeff = 13L;
                        break;
                    case 'E':
                        coeff = 14L;
                        break;
                    case 'F':
                        coeff = 15L;
                        break;
                }
            }
            else
            {
                coeff = long.Parse(hexNumber[i].ToString());
            }

            decimalNumber += coeff * (long)Math.Pow(16, pow);
        }

        Console.WriteLine(decimalNumber);
    }
}


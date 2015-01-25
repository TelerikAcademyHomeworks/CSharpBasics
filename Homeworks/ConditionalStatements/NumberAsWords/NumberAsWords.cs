using System;

//Problem 11.* Number as Words

//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

class NumberAsWords
{
    public static string LastDigitTranslator(int number)
    {
        string numberAsWord = "";

        switch (number)
        {
            case 0:
                numberAsWord = "zero";
                break;
            case 1:
                numberAsWord = "one";
                break;
            case 2:
                numberAsWord = "two";
                break;
            case 3:
                numberAsWord = "three";
                break;
            case 4:
                numberAsWord = "four";
                break;
            case 5:
                numberAsWord = "five";
                break;
            case 6:
                numberAsWord = "six";
                break;
            case 7:
                numberAsWord = "seven";
                break;
            case 8:
                numberAsWord = "eight";
                break;
            case 9:
                numberAsWord = "nine";
                break;
        }

        return numberAsWord;
    }

    public static string NumbersFromTenToNineteen(int number)
    {
        string numberAsWord = "";

        switch (number)
        {
            case 10:
                numberAsWord = "ten";
                break;
            case 11:
                numberAsWord = "eleven";
                break;
            case 12:
                numberAsWord = "twelve";
                break;
            case 13:
                numberAsWord = "thirteen";
                break;
            case 14:
                numberAsWord = "fourteen";
                break;
            case 15:
                numberAsWord = "fifteen";
                break;
            case 16:
                numberAsWord = "sixteen";
                break;
            case 17:
                numberAsWord = "seventeen";
                break;
            case 18:
                numberAsWord = "eighteen";
                break;
            case 19:
                numberAsWord = "nineteen";
                break;
        }

        return numberAsWord;
    }

    public static string SecondDigitTranslator(int number)
    {
        string numberAsWord = "";

        switch (number)
        {
            case 1:
                numberAsWord = "ten";
                break;
            case 2:
                numberAsWord = "twenty";
                break;
            case 3:
                numberAsWord = "thirty";
                break;
            case 4:
                numberAsWord = "fourty";
                break;
            case 5:
                numberAsWord = "fifthy";
                break;
            case 6:
                numberAsWord = "sixty";
                break;
            case 7:
                numberAsWord = "seventy";
                break;
            case 8:
                numberAsWord = "eighty";
                break;
            case 9:
                numberAsWord = "ninety";
                break;
        }

        return numberAsWord;
    }

    public static string FirstDigitTranslator(int number)
    {
        string numberAsWord = "";

        switch (number)
        {
            case 1:
                numberAsWord = "one hundred";
                break;    
            case 2:
                numberAsWord = "two hundred";
                break;
            case 3:
                numberAsWord = "three hundred";
                break;
            case 4:
                numberAsWord = "four hundred";
                break;
            case 5:
                numberAsWord = "five hundred";
                break;
            case 6:
                numberAsWord = "six hundred";
                break;
            case 7:
                numberAsWord = "seven hundred";
                break;
            case 8:
                numberAsWord = "eight hundred";
                break;
            case 9:
                numberAsWord = "nine hundred";
                break;
        }

        return numberAsWord;
    }

    static void Main()
    {
        Console.WriteLine("Please enter a number from [0..999]");
        int number = int.Parse(Console.ReadLine());

        if (number < 0 || number > 999)
        {
            Console.WriteLine("Invalid number");
        }
        else if (number >=0 && number < 10)
        {
            Console.WriteLine(LastDigitTranslator(number));
        }
        else if (number >= 10 && number < 20)
        {
            Console.WriteLine(NumbersFromTenToNineteen(number));
        }
        else if (number >= 20 && number < 100)
        {
            if ((number % 10) == 0)
            {
                Console.WriteLine(SecondDigitTranslator(number / 10));
            }
            else
            {
                Console.WriteLine(SecondDigitTranslator(number / 10) + " " + LastDigitTranslator(number % 10));
            }
        }
        else if (number >= 100 && number <= 999)
        {
            if (number % 100 == 0)
            {
                Console.WriteLine(FirstDigitTranslator(number / 100));
            }
            else
            {
                if (number % 10 == 0)
                {
                    Console.WriteLine(FirstDigitTranslator(number / 100) + " and " + SecondDigitTranslator((number / 10) % 10));
                }
                else
                {
                    if ((number % 100) >= 10 && (number % 100) < 20)
                    {
                        Console.WriteLine(FirstDigitTranslator(number / 100) + " and " + NumbersFromTenToNineteen(number % 100));
                    }
                    else
                    {
                        Console.WriteLine(FirstDigitTranslator(number / 100) + " and " + SecondDigitTranslator((number / 10) % 10) + " " + LastDigitTranslator(number % 10));
                    }
                    
                }
            }
        }
    }
}


using System;

//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
using System.Linq;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Please enter number with space between them: ");
        string inputString = Console.ReadLine();

        string[] numbersAsStrings = inputString.Split(' ');

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0, j = 1; i < numbersAsStrings.Length; i++,j++)
        {
            if (j % 2 == 0)
            {
                evenProduct *= int.Parse(numbersAsStrings[i]);
            }
            else
            {
                oddProduct *= int.Parse(numbersAsStrings[i]);
            }
        }

        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("The product is: {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
    }
}


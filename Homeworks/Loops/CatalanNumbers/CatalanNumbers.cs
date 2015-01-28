using System;
using System.Numerics;

//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).

class CatalanNumbers
{
    public static BigInteger Factorial(int number)
    {
        if (number == 0) return 1;
        return number * Factorial(number - 1);
    }

    static void Main()
    {
        Console.WriteLine("Please enter n: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger twoMultNFac = Factorial(2*n);
        BigInteger nPulsOneFac = Factorial(n + 1);
        BigInteger nFac = Factorial(n);

        BigInteger catalanNumber = twoMultNFac/(nPulsOneFac*nFac);

        Console.WriteLine(catalanNumber);
    }
}


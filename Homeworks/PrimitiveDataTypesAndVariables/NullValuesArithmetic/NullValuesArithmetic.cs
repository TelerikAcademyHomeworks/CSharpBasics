using System;

//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

class NullValuesArithmetic
{
    static void Main()
    {
        int? firstVar = null;
        double? secondVar = null;
        Console.WriteLine("First nullable value is: {0}, second nullable value is: {1}", firstVar, secondVar);

        Console.WriteLine("Adding numbers to nullable values and print them: ");
        Console.WriteLine("First variable plus 5 = {0}", firstVar + 5);
        Console.WriteLine("Second variable plus 10 = {0}", secondVar + 10);
    }
}


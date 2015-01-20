using System;

//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Please enter base1 of trapezoid: ");
        double baseOne = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter base2 of trapezoid: ");
        double baseTwo = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter height of trapezoid: ");
        double height = double.Parse(Console.ReadLine());

        double trapezoidArea = (baseOne + baseTwo)*height/2.0;

        Console.WriteLine("Area is: {0}", trapezoidArea);
    }
}


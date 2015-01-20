using System;

//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

class Rectangles
{
    static void Main()
    {
        Console.Write("Please enter rectangle's side a: ");
        string inputStringA = Console.ReadLine();
        Console.Write("Please enter rectangle's side b: ");
        string inputStringB = Console.ReadLine();
        double aSide = double.Parse(inputStringA);
        double bSide = double.Parse(inputStringB);

        double rectPerimeter = aSide*2 + bSide*2;
        double rectArea = aSide*bSide;

        Console.WriteLine("Rectangle with side a: {0} and b: {1}, has perimeter: {2} and area: {3}",
            aSide, bSide, rectPerimeter, rectArea);
    }
}


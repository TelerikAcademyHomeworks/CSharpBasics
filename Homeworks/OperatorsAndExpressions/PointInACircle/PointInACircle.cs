using System;

//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Please enter coordinate x: ");
        string xCoordinate = Console.ReadLine();
        Console.WriteLine("Please enter coordinate y: ");
        string yCoordinate = Console.ReadLine();

        const int radius = 2;

        bool isInCircle = Math.Pow(double.Parse(xCoordinate), 2) + Math.Pow(double.Parse(yCoordinate), 2) <=
                          Math.Pow(radius, 2);

        if (isInCircle)
        {
            Console.WriteLine("The point is in the circle!");
        }
        else
        {
            Console.WriteLine("The point is not in a circle!");
        }
    }
}


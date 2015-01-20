using System;

//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

class PointInsideACircleOutsideOfRectangle
{
    static void Main()
    {
        Console.WriteLine("Please enter coordinate x: ");
        double xCoordinate = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter coordinate y: ");
        double yCoordinate = double.Parse(Console.ReadLine());

        // circle's coordinates
        const double radius = 1.5;
        const double radiusXCoordinate = 1;
        const double radiusYCoordinate = 1;

        // rectangle's coordinates ABCD
        // side CD is the top of the rectangle
        const double sideCDYcoordinate = 1;
        // side AD is the left of the rectangle
        const double sideADXCoordinate = -1;
        // side AB is the bottom of the rectangle
        const double sideABYCoordinate = -1;
        // side BC is the right of the rectangle 
        const double sideBCXCooridnate = 5;

        bool isInCircle = Math.Pow(xCoordinate - radiusXCoordinate, 2) + Math.Pow(yCoordinate - radiusYCoordinate, 2) <=
                          Math.Pow(radius, 2);

        //bool isOutSideOfRectangle = xCoordinate < sideADXCoordinate || xCoordinate > sideBCXCooridnate ||
        //    yCoordinate > sideCDYcoordinate || yCoordinate < sideABYCoordinate;

        
        // Because the rectangle splits the circle into 2 equal halfs where one is inside the rectangle 
        // and the another one is outside of it we can do only one condition 

        bool isOutSideOfRectangle = yCoordinate > sideCDYcoordinate;

        if (isInCircle && isOutSideOfRectangle)
        {
            Console.WriteLine("The point with coordinates({0}, {1}) is inside the cirlce and outside of rectangle.",
                xCoordinate, yCoordinate);
        }
        else
        {
            Console.WriteLine("The point is not in the circle or is inside the rectangle.");
        }
    }
}

using System;

//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Please enter radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        double circlePerimeter = 2*Math.PI*radius;
        double circleArea = Math.PI*Math.Pow(radius, 2);

        Console.WriteLine("Circle with radius: {0} has perimeter = {1:f2} and area = {2:f2}", 
            radius, circlePerimeter, circleArea);
    }
}


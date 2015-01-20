using System;

//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

class QuadricEquation
{
    static void Main()
    {
        Console.WriteLine("Please enter coefficient a: ");
        double aCoefficient = double.Parse(Console.ReadLine());

        Console.WriteLine("Please ente coefficient b: ");
        double bCoefficient = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter coefficient c: ");
        double cCoefficient = double.Parse(Console.ReadLine());

        double discriminant = Math.Pow(bCoefficient, 2) - 4*aCoefficient*cCoefficient;

        double x1 = 0;
        double x2 = 0;

        if (discriminant < 0)
        {
            Console.WriteLine("Equation have no real roots");
        }
        else if (discriminant == 0)
        {
            x1 = -bCoefficient/(2*aCoefficient);
        }
        else if(discriminant > 0)
        {
            x1 = (-(bCoefficient) + Math.Sqrt(discriminant))/(2*aCoefficient);
            x2 = (-(bCoefficient) - Math.Sqrt(discriminant)) / (2 * aCoefficient);
        }

        if (x2 == 0)
        {
            Console.WriteLine("There is only one square root {0}", x1);
        }
        else
        {
            Console.WriteLine("There are two square roots x1 = {0} and x2 = {1}", x1, x2);
        }
    }
}


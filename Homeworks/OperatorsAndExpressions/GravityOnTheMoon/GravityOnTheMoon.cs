using System;

//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

class GravityOnTheMoon
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        double weightOnEarth = double.Parse(inputString);

        Console.WriteLine("On earth this weight is {0}, on the moon same wight is: {1}", 
            weightOnEarth, weightOnEarth * (17.0/100));
    }
}


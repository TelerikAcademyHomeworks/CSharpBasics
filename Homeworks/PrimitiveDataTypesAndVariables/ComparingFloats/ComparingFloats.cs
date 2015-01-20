using System;

//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

class ComparingFloats
{
    static void Main()
    {
        float firstNumber = 4.999999f;
        float secondNum = 4.999998f;

        float eps = 0.000001f;
        double diff = Math.Abs(firstNumber - secondNum);
        diff = Math.Round(diff, 7);
        bool isEqual;

        // 1.First way of creating if expression

        //if (diff >= eps)
        //{
        //    isEqual = false;
        //}
        //else
        //{
        //    isEqual = true;
        //}

        // 2.Second way with ternary operator

        //isEqual = (diff >= eps) ? false : true;

        // 3.Third way with ! and expression

        isEqual = (!(diff >= eps));

        Console.WriteLine("Is the tow numbers equal with precison to eps = 0.000001: {0}", isEqual);


    }
}


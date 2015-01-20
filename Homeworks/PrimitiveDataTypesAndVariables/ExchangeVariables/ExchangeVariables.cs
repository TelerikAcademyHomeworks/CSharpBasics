using System;

//Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

class ExchangeVariables
{
    static void Main()
    {
        int firstNum = 5;
        int secondNum = 10;
        int container = 0;

        Console.WriteLine("first number value is: {0} second number value is: {1}", firstNum, secondNum);

        container = firstNum;
        firstNum = secondNum;
        secondNum = container;
        Console.WriteLine("We make exchange!");
        Console.WriteLine("first number value is: {0} second number value is: {1}", firstNum, secondNum);
    }
}


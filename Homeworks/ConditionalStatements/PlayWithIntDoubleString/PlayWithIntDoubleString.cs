using System;

//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("1 --> string");

        string inputCommand = Console.ReadLine();

        string inputString = "";

        switch (inputCommand)
        {
            case "int":
                Console.WriteLine("Please enter int");
                inputString = Console.ReadLine();
                inputString = (int.Parse(inputString) + 1).ToString();
                break;
            case "double":
                Console.WriteLine("Please enter double");
                inputString = Console.ReadLine();
                inputString = (decimal.Parse(inputString) + 1).ToString();
                break;
            case "string":
                Console.WriteLine("Please enter string");
                inputString = Console.ReadLine();
                inputString += "*";
                break;
        }

        Console.WriteLine(inputString);
    }
}


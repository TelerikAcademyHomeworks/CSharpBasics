using System;

class Program
{
    static void Main()
    {
        int age = 0;

        Console.Write("Please enter your age: ");

        while (true)
        {
            string inputString = Console.ReadLine();
            if (int.TryParse(inputString, out age))
            {
                break;
            }
            Console.WriteLine("Your age shoul be a valid number: ");
        }

        Console.WriteLine("Your age after ten years will be: {0}", age + 10);
    }
}


using System;

//Problem 3. Check for a Play Card

//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:

class CheckForAPlayerCard
{
    static void Main()
    {
        Console.WriteLine("Please enter a player card: ");
        string inputString = Console.ReadLine();

        //int result;

        //if (int.TryParse(inputString, out result))
        //{
        //    if (result >= 2 && result <= 10)
        //    {
        //        Console.WriteLine("yes");
        //    }
        //    else
        //    {
        //        Console.WriteLine("no");
        //    }
        //}
        //else
        //{
        //    if (inputString == "Q" || inputString == "J" || inputString == "A" || inputString == "K")
        //    {
        //        Console.WriteLine("yes");
        //    }
        //    else
        //    {
        //        Console.WriteLine("no");
        //    }
        //}

        switch (inputString)
        {
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A":
                Console.WriteLine("yes");
                break;
            default :
                Console.WriteLine("no");
                break;
        } 
    }
}


using System;

//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).

class CompareCharArrays
{
    public static char[] InitializeArr(int arrLength)
    {
        char[] arr = new char[arrLength];

        for (int i = 0; i < arrLength; i++)
        {
            Console.Write("Please enter arr[{0}] = ", i);

            arr[i] = char.Parse(Console.ReadLine());
        }

        return arr;
    }

    private static void Main()
    {
        Console.WriteLine("Please enter first array length: ");
        int firstArrLength = int.Parse(Console.ReadLine());
        char[] firstArr = InitializeArr(firstArrLength);
        bool isEqual = true;

        Console.WriteLine("Please enter second array length: ");
        int secondArrLength = int.Parse(Console.ReadLine());
        char[] secondArr = InitializeArr(secondArrLength);

        if (firstArrLength > secondArrLength)
        {
            Console.WriteLine("First array is bigger than the second array");
        }
        else if (secondArrLength > firstArrLength)
        {
            Console.WriteLine("Second array is bigger than the first array");
        }
        else
        {
            for (int i = 0; i < firstArrLength; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    isEqual = false;
                    break;
                }
            }

            if (isEqual)
            {
                Console.WriteLine("The two arrays are equal");
            }
            else
            {
                Console.WriteLine("The two arrays are not equal");
            }
        }
    }
}


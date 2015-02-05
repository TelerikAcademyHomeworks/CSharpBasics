using System;

//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.

class CompareArrays
{
    public static int[] InitializeArr(int arrLength)
    {
        int[] arr = new int[arrLength];

        for (int i = 0; i < arrLength; i++)
        {
            Console.Write("Please enter arr[{0}] = ", i);

            arr[i] = int.Parse(Console.ReadLine());
        }

        return arr;
    }

    static void Main()
    {
        Console.WriteLine("Please enter first array length: ");
        int firstArrLength = int.Parse(Console.ReadLine());
        int[] firstArr = InitializeArr(firstArrLength);
        bool isEqual = true;

        Console.WriteLine("Please enter second array length: ");
        int secondArrLength = int.Parse(Console.ReadLine());
        int[] secondArr = InitializeArr(secondArrLength);

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


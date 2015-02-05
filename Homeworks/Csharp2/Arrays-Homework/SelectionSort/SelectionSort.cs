using System;

//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Please enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());

        var numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Please enter numbers[{0}]", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int curElement;
        int minElement = int.MaxValue;
        int elementIndex = 0;
        int container;

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < numbers.Length; j++)
            {
                curElement = numbers[j];

                if (curElement < minElement)
                {
                    minElement = curElement;
                    elementIndex = j;
                }
            }

            container = numbers[i];
            numbers[i] = numbers[elementIndex];
            numbers[elementIndex] = container;
            minElement = int.MaxValue;
            elementIndex = 0;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(i != numbers.Length -1 ? numbers[i].ToString() + ", " : numbers[i].ToString());
        }

        Console.WriteLine();
    }
}


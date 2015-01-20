using System;

class CurrentDateAndTIme
{
    static void Main()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine(date.ToString("yyy-MM-dddd"));
    }
}


using System;

class PringLongSequence
{
    static void Main()
    {
        int member = 2;
        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine(member);
            Console.WriteLine(-(member + 1));
            member += 2;
        }
    }
}


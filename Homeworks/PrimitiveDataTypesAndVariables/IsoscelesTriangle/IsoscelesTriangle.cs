using System;

//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©

//  © ©

// ©   ©

//© © © ©
//Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

//Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (i == 4 && i != (j - 1))
                {
                    Console.Write("© © © ©");
                    break;
                }
                else
                {
                    if (i == 2)
                    {
                        Console.Write("  © ©");
                        break;
                    }
                    if (i == 3)
                    {
                        Console.Write(" ©   ©");
                        break;
                    }
                    Console.Write(new string(' ', 4 - i));
                    Console.Write("©");    
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}


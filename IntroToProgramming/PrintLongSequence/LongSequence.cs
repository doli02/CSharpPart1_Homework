
//Problem 16.* Print Long Sequence
//
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …




using System;

class LongSequence
{
    static void Main()
    {
        for (long i = 2; i < (2 + 1000); i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("{0},", i);
            }
            else
            {
                Console.Write("{0},", -i);
            }
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}


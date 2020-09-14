using System;

class iterationStatement
{

    public void LearnForLoop()
    {


        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("HEHEHAHAHAHEHEAHAHA.");
        }

        int[] numbers = { 34, 5, 6, 78, 90 };
        foreach (int x in numbers)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is even.");

            }
            else
            {
                Console.WriteLine($"{x} is odd. ");
            }
        }

    }

    public void LearnWhileLoop()
    {
        // int i = 0;
        // while(i<10)
        // {
        //     Console.WriteLine("blabalbalablablabala");
        //     i++;
        // }
        char confirm = 'y';
        while (confirm == 'y')
        {
            Console.WriteLine("Hello bro");
            Console.WriteLine("Print one more time");
            confirm = Console.ReadKey().KeyChar;

        }
    }


}
using System;

class IterationStatement
{
    static void Main22()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnForLoop();
    }
    void LearnForLoop()
    {
        for(int i =0; i < 10; i++)
        {
            Console.WriteLine("I am beautiful.");
        }

        int[] numbers = {34, 5, 6, 78, 90};

        foreach(int x in numbers)
        {
            if(x % 2 == 0)
            {
                Console.WriteLine($"{x} is even.");

            }
            else
            {
                Console.WriteLine($"{x} is odd.");
            }
        }
    }
}
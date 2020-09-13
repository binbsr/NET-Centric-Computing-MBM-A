using System;

class IterationStatement
{
    static void Main2()
    {
        IterationStatement i1 = new IterationStatement();
        i1.LearnForLoop();
    }
    public void LearnForLoop()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("The index number is :" + i);
        }

        int[] numbers = { 34, 35, 36, 37, 38, 39, 40 };
        foreach (int x in numbers)
        {
            if (x % 2 == 1)
            {
                Console.WriteLine($"{x} is odd.");
            }
            else
            {
                Console.WriteLine($"{x} is even.");
            }
        }
    }

    public void LearnWhileLoop()
    {
        int j = 0;
        while (true)
        {
            Console.WriteLine($"Number {j}");
            j++;
            if (j > 10)
            {
                break;
            }
        }

        char confirm = 'y';
        Console.WriteLine("Are you beautiful ?");
        while (confirm == 'y')
        {
            Console.WriteLine("Are you sure ?");
            Console.WriteLine("Press Y for yes or N for no ");
            confirm = Console.ReadKey().KeyChar;
        }
    }
}
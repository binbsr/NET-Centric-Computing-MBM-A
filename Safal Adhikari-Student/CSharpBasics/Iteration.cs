using System;

class IterationStatement
{
    static void Main3()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnWhileLoop();
    }
    void LearnForLoop()
    {
        for(int i=0; i< 10; i++)
        {
            Console.WriteLine("My name is Bond! James Bond.");
        }
        int[] numbers = { 34, 3, 6, 23, 89};

        foreach (int x in numbers)
        {
            if(x%2 == 0)
            {
                Console.WriteLine($"{x} is even.");
            }
            else
            {
                Console.WriteLine($"{x} is odd.");
                
            }
        }
    }

    void LearnWhileLoop()
    {
        char confirm = 'Y';
        while(confirm == 'Y')
        {
            Console.WriteLine("Hola! Como estas");
            Console.WriteLine("Do you want to print one more?");
            confirm = Console.ReadKey().KeyChar;
        }

       do
        {
            Console.WriteLine("Hola! Como estas");
            Console.WriteLine("Do you want to print one more?");
            confirm = Console.ReadKey().KeyChar;
        } while(confirm == 'Y');
    }
}
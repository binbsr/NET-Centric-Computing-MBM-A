using System;
class IterationStatement
{
    static void Main3()
    {
        IterationStatement iterationStatement =new IterationStatement();
        iterationStatement.LearnWhileLoop();
    }
    void LearnForLoop()
    {
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("I am beautiful");
        }
        int [] numbers ={29,3,5,4,3};
        foreach(int x in numbers)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is even");
            }
            else
            {
                 Console.WriteLine($"{x} is odd");
            }
        }
        
    }
    void LearnWhileLoop()
    {
        char confirm='Y';
        while(confirm == 'Y')
        {
            Console.WriteLine("Hey beautiful");
            Console.WriteLine("Print once more?");
            confirm = Console.ReadKey().KeyChar;
        }
        
    }
}

using System;

class IterationStatement
{
    static void Main3()
    {
        IterationStatement iteration=new IterationStatement();
        iteration.LearnForLoop();

    }
    void LearnForLoop()

    {
        // for(int i=0;i<=10;i++){
        // Console.WriteLine("I am beautiful.");
        // }

        int[] numbers={12,13,14,15};

        foreach(int x in numbers)
        {
            if(x%2==0)
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
       
        // int i=0;
        // while (i<10)
        // {
        //     Console.WriteLine("I am beautiful.");
        //     i++;
        // }

        char confirm='Y';
        while (confirm=='Y')
        {
            Console.WriteLine("I am beautiful.");
            Console.WriteLine("Print one more time?");
            confirm=Console.ReadKey().KeyChar;
        }


    }
}
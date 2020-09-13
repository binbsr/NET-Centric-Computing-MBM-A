using System;
class IterationStatement
{
    static void Main5()
    {
        IterationStatement iterationStatement =new IterationStatement();
        
        iterationStatement.LearnWhileLoop();
    }

    void LearnForLoop()
    {
        for(int i=0; i<10; i++)
        {
        Console.WriteLine("Hey!");
        }
    int[] numbers= {34,45,56,67};

         foreach (int x in numbers)
        {
            if(x%2 == 0)
            {
                Console.WriteLine($"({x} is even") ;
            }
            else
                {
                    Console.WriteLine($"{x} is odd") ;
                }     
        }

    }

    void LearnWhileLoop()
    {
        char confirm='Y';
        while(confirm == 'Y')
        {
            Console.WriteLine("Hey!");
            Console.WriteLine("Print that again?");
            confirm=Console.ReadKey().KeyChar;
        
        }

    }
    
}

     
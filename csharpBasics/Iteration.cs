using System;

class IterationStatement
{
    static void Main9()
    {

        IterationStatement kk =new IterationStatement();
        kk.LearnForLoop();
    }
    void LearnForLoop()
    {
        for(int i=0;i<10;i++)
        {
        Console.WriteLine("Iam beautiful.");
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
                {
                    Console.WriteLine($"{x} is odd") ;
                }
            }
        }


    }
    void LearnWhileLoop()
    {
        char confirm ='Y';
        while (confirm =='Y')
            {
            Console.WriteLine("I'm beautiful.");
            Console.WriteLine("print one more?");
            confirm = Console.ReadKey().KeyChar;
            }
            do{
            Console.WriteLine("I'm beautiful.");
             Console.WriteLine("print one more?");
            confirm =Console.ReadKey().KeyChar;
            }while (confirm=='Y');
            
        }
    
}
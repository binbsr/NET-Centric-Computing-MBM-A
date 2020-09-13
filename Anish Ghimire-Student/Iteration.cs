using System;
class IterationStatement
{
    static void Main11()
    {
        IterationStatement iterationStatement= new IterationStatement();
        iterationStatement.LearnWhileLoop();
    }
    void LearnForLoop()
    {
        for (int i=0; i<10;i++)
        {
            Console.WriteLine("Iam beautiful");
        }
        int[] numbers={34,5,6,78,90};
        foreach (int x in numbers)
        {
            if (x%2==0)
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
                char confirm ='Y';
                while(confirm=='Y')
                {
                    Console.Write("Iam not that beautiful");
                    Console.WriteLine("print again?");
                    confirm=Console.ReadKey().KeyChar;//Console.ReadLine...

                }
            }
        


    
}
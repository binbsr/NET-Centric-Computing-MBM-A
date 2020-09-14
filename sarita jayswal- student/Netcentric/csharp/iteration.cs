using System;
class IterationStatement
{
    static void Main()
   {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnWhileLoop();

    }
    void LearnForLoop() 
{
        for(int i = 0; i < 10; i++)
        {
        Console.WriteLine("I read");
        }
    
    int[] numbers = {34, 5, 6, 78, 90};
    foreach (int x in numbers)
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
void LearnWhileLoop1()
{
int i = 0;
while(i < 10)
{
    Console.WriteLine("Nice");
    i++;
}

}
void LearnWhileLoop()
{
    char confirm = 'y';
    while(confirm == 'y')
    {
        Console.WriteLine("Nice");
        Console.WriteLine("Print One More time");
        confirm = Console.ReadKey().KeyChar;

    }
}

}

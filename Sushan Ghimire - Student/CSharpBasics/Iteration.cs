using System;

class IterationStatement
{
    static void Main4()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnWhileLoop();
    }
    void LearnForLoop()
    {
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ram Bahadur is a boy.");
        }

        int[] numbers = {5, 70, 9, 10, 5};
        foreach(int x in numbers)
        {
            if (x % 2 != 0 )
            {
                Console.WriteLine($"{x} is odd."); //$ sign is use for interpolarion; if variable value has to be declared
            }
            else{
                Console.WriteLine($"{x} is even.");
            }
        }
    }

    void LearnWhileLoop()
    {
        char confirm = 'Y';
        while(confirm == 'Y' || confirm == 'y')
        {
            Console.WriteLine("Ram is a boy.");
            Console.WriteLine("Print again? (Y/N)");
            confirm = Console.ReadKey().KeyChar;
        }

        do 
        {
            Console.WriteLine("Shyam is a boy.");
            Console.WriteLine("Print again? (Y/N)");
            confirm = Console.ReadKey().KeyChar;
        } while(confirm == 'Y' || confirm == 'y');
    }
}
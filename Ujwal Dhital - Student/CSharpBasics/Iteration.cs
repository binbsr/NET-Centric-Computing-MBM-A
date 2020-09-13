using System;

class IterationStatement
{
    static void Main3()
    {
        IterationStatement obj2 = new IterationStatement();
        obj2.LearnForLoop();
    }

    int[] numArray = { 1, 2, 3 };
    void LearnForLoop()
    {



        int i;
        //for loop in c sharp
        foreach (int n in numArray)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} is even");

            }
            else
            {
                Console.WriteLine($"{n} is odd");

            }

        }
    }


    void LearnWhileLoop()
     
     {
         char confirm = 'Y';
         while(confirm=='Y')
         {
            Console.WriteLine("I am hansome.");
            Console.WriteLine("Print one more time?");
            confirm = Console.ReadKey().KeyChar; 
         }
         do
         {
            Console.WriteLine("I am hansome.");
            Console.WriteLine("Print one more time?");
            confirm = Console.ReadKey().KeyChar;  
         } while(confirm=='Y');
     }
}
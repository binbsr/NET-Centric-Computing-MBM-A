using System;

class IterationStatement
{
    static void Main12345()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnWhileloop();

    }


   void LearnForloop()
    {
        for(int i = 0; i<10; i++)
        Console.WriteLine("I am Cosmic");
    }

     void LearnWhileloop()
    {
        char confirm = 'Y';
        while(confirm == 'Y')
        {
        Console.WriteLine("I am Cosmic");
        Console.WriteLine("Wanna continue?");
        confirm = Console.ReadKey().KeyChar;
        }
    }

    //  int[] numbers = {1,2,3,4,5};

    //  foreach (int x in numbers)
    //  {
    //      if(x%2==0)
    //      {
    //          Console.WriteLine($"{x} is even.")
    //      }
    //      else
    //      {
    //          Console.WriteLine($"{x} is odd.")
    //      }
    //  }

}
using System;
 
class Question1
{
    
    internal void Sum()
    {
        Console.Write("Input first integer: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Input second integer: ");
        int y = int.Parse(Console.ReadLine());
        bool test = x + y > 500;
 
        Console.WriteLine($"Result: {test}");
    }
}







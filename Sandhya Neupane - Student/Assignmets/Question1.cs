//Given two numbers, write C# method that returns true if sum of both numbers is greater than 500. Otherwise returns false.

using System;

public class SumChecker  
{
    internal bool Number(int x, int y)
    {
        Console.WriteLine("Enter first number: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        int y = int.Parse(Console.ReadLine());
        
        int sum = x + y;
        if (sum > 500)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
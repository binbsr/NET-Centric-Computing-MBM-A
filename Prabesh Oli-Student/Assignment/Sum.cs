using System;
public class Sum{
    internal void SumMethod()
    {
        Console.WriteLine("Enter two number");
        int a = int.Parse(Console.ReadLine());
        int b= int.Parse(Console.ReadLine());
        int sum = a+b;
        Console.Write($"sum is {sum} so,");
        if (sum>500){
            Console.WriteLine("True");
        }
        else
        Console.WriteLine("false");
    }
}
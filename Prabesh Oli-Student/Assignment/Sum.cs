using System;
public class Sum{
    internal void SumMethod()
    {
        Console.WriteLine("Enter two number");
        String x, y;
        x = Console.ReadLine();
        y= Console.ReadLine();
        int a = int.Parse(x);
        int b= int.Parse(y);
        int sum = a+b;
        Console.Write($"sum is {sum} so,");
        if (sum>500){
            Console.WriteLine("True");
        }
        else
        Console.WriteLine("false");
    }
}
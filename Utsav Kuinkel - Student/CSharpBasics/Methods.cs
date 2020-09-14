using System;

public class MethodTeacher
{

    // Simple method: with 2 arguments and a return typr
    public int EvenAdder(params int[] arr)
    {
        int SumEven = 0;
        foreach (int i in arr)
        {
            if (i % 2 == 0)
            {
                SumEven += i;
            }
        }
        return SumEven;
    }

    public double Sum(params double[] numbers)
    {
        double sum = 0;
        foreach (double num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    //Returning multiple value 
    //Example: Method to find minand max fron set of numbers
    internal (int, int) FindMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }
        return (min, max);
    }

    // Named-arguments
    internal void PrintCostumerDetails(string name, byte age, string address)
    {
        Console.WriteLine($"Name : {name}[{age}], Address: {address}");
    }
}

public class MethodTester
{
    static void Main()
    {
        MethodTeacher methodTeacher = new MethodTeacher();
        int[] numbers = { 32, 345, 234, 234, 2345, 4567, 78, 234, 567, 23, 5, 2, 4, 56 };
        (int Min, int Max) result = methodTeacher.FindMinMax(numbers);
        Console.WriteLine($"Minimum: {result.Min}, Maximum:{result.Max}");
        methodTeacher.PrintCostumerDetails("Utsav", 21, "Mulpani");
    }
}
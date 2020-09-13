using System;
using EnumsAndProperties;

public class MethodLearner
{
    // static void Main()
    // {
    //     MethodLearner methodLearner = new MethodLearner();
    //     double sum = methodLearner.Sum(2345.443, 4373.67);
    //     Console.WriteLine($"Sum is {sum}");
    // }

    //Simple method: with 2 arguments and a return type
    public double Sum(double firstNum, double secondNum)
    {
        DayWeek x; 
        return firstNum + secondNum;
    }

    //Variable-number of arguments 
    public double Sum(params double[] numbers)
    {
        double sum = 0;
        foreach (double num in numbers)
        {
            sum = sum + num;
        }
        return sum;
    }

    // Returning multiple value - Using tuples
    // Example: Method to find min and max from set of numbers.
    internal (int, int) FindMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];

        foreach(int num in numbers)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }

        return (min, max);
    }

    //Named-arguments
    internal void PrintCustomerDetails(string name, byte age, string address)
    {
        Console.WriteLine($"Name: {name}[{age}], Address: {address}");
    }

    // Generic Methods
    public void Sum<T>(T firstNum, T secondNum)
    {}
}

public class MethodTester
{
    static void Main()
    {
        MethodLearner methodLearner = new MethodLearner();
        
        int[] numbers = {34,5,26,37,31,43,64,32};
        (int Min, int Max) result = methodLearner.FindMinMax(numbers);

        Console.WriteLine($"Minimum: {result.Min}, Maximum: {result.Max}");
        
        // Named-arguments
        methodLearner.PrintCustomerDetails(age: 21, address: "Lalitpur", name: "Sandhya");

        // methodLearner.Sum<float>(345.34f, 3456.34f);
    }
}


    
    
    // Question 1 : Return SUM of even numbers from supplied 6 integer numbers

    // public int SumEvens(int a, int b, int c, int d, int e, int f)
    // { 
    //     int sum = 0;
    //     if (a % 2 == 0)
    //         sum = sum + a;
    //     if (b % 2 == 0)
    //         sum = sum + b;
    //     if (c % 2 == 0)
    //         sum = sum + c;
    //     if (d % 2 == 0)
    //         sum = sum + d;
    //     if (e % 2 == 0)
    //         sum = sum + e;
    //     if (f % 2 == 0)
    //         sum = sum + f;
        
    //     return sum;
    // }

//     public int SumEvens( params int[] nums)
//     {
//         int sum = 0;

//         foreach (int num in nums)
//         {
//             if (num % 2 == 0)
//                 sum = sum + num;
//         }
//         return sum;
//     }

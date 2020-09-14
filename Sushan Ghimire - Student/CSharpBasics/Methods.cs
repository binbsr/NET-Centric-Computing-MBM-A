using System;
using EnumsAndProperties;

public class MethodTeacher
{

    //simple method with 2 arguments and a return type
    public double Sum(double firstNum, double secondNum)
    {
        DayWeek x;
        return firstNum + secondNum;
    }

    //variable number of arguments
    public double Sum(params double[] numbers)
    {
        double sum = 0;
        foreach ( double num in numbers)
        {
            sum = sum + num;
        }

        return sum;
    }

    // Returning multiple value - Using tuples
    
    //Example: Method to find min and max from the given set of numbers
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


    //Q1: Program to return sum of even numbers from the given set of arguments
    public int SumEvens(params int[] nums)
    {
        int sum = 0;

        foreach (int num in nums)
        {
            if(num % 2 == 0)
                sum += num;
        }

        return sum;
    }

    // Named-arguments
    internal void PrintCustomerDetails(string name, byte age, string address)

    {
        Console.WriteLine($"Name: {name}[{age}], Address: {address}");
    }


    // Generic methods
    public void Sum<T>(T firstNum, T secondNum)
    {

    }
}




public class MethodTester
{
    static void Main()
    {
        MethodTeacher methodTeacher = new MethodTeacher();

        int[] numbers = { 34, 5, 7, 88, 77, 5, 2 };
        (int Min, int Max) result = methodTeacher.FindMinMax(numbers);

        Console.WriteLine($"Minimum is : {result.Min}, Maximum value is : {result.Max}");

        // Named-arguments
        methodTeacher.PrintCustomerDetails(age: 22, address: "Lagankhel", name: "Sushan");

        methodTeacher.Sum<float>(345.22f, 451.29f);
    }
}
using System;

public class MethodTeacher1
{
    static void Main()
    {
        MethodTeacher1 methodTeacher = new MethodTeacher1();
        double sum = methodTeacher.Sum(2345.6, 23452.1);
        Console.WriteLine($"Sum is {sum}");
        // int[] setNumbers = new int[] { };
        double sumEven = methodTeacher.EvenAdder(12, 34, 54, 23, 45, 23, 45, 23);
        Console.WriteLine($"Sum of evens is {sumEven}");

        int[] numbers = { 12, 13, 15, 2, 4, 6, 099 };
        (int, int) result = methodTeacher.FindMinMax(numbers);

        Console.WriteLine($"The min value is :{result.Item1} and max value is : {result.Item2}");
        methodTeacher.PrintCustomerDetails(age: 32, address: "Kalanki", name: "hahah");

        methodTeacher.Sum<float>(12.4f, 34.7f);


    }
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

    internal void PrintCustomerDetails(string name, byte age, string address)
    {
        Console.WriteLine($"Name: {name} [{age}], Address: {address}");

    }

    //generic methods
    public void Sum<T>(T firstNum, T secondNum)
    {


    }







}
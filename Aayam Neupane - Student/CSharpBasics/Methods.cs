using System;
using EnumsAndProporties;

public class MethodLearner
{
    static void Main55()
    {
        MethodLearner methodLearner = new MethodLearner();
        double sum = methodLearner.Sum(2345.568, 59634.1);
        Console.WriteLine($"Sum is {sum}");
    }
    public double Sum(double firstNum, double secondNum)
    {
        DayWeek x;
        return firstNum + secondNum;
    }

    //Return Sum of even numbers from supplied 6 parameters
    public int SumEven(params int[] nums)
    {
        int sum = 0;
        foreach (int num in nums)
        {
            if (num % 2 == 0)
                sum += num;
        }
        return sum;
    }
    //named arguments 
    internal void PrintCustomerDetails(string name, byte age, string address)
    {
        Console.WriteLine($"Name: {name}[{age}], Address: {address}");
    }

    //variable method of arguments
    public double Sum(params double[] numbers)
    {
        double sum = 0;
        foreach (double num in numbers)
        {
            sum += num;
        }

        return sum;
    }

    //user data type (Generics method)
    public void Sum<T>(T firstNum, T secondNum)
    {

    }

    //Returning multiple value - Using Tuples.
    //Example: Method Find min and max from set of numbers
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
}
public class MethodTester
{
    static void Main()
    {
        MethodLearner methodLearner = new MethodLearner();
        int[] numbers = { 3, 45, 78, 459, 65, 75, 15, 44 };
        (int Min, int Max) result = methodLearner.FindMinMax(numbers);
        Console.WriteLine($"Minimum: {result.Min}, Maximum: {result.Max}");

        //named arguments
        methodLearner.PrintCustomerDetails("Aayam", 23, "Jagati");

        methodLearner.Sum<float>(345.5f, 458.2f);
    }

}
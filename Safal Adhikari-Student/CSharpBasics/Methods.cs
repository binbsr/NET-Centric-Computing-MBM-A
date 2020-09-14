using System;
using EnumsAndProperties;

public class MethodTeacher
{
    /*
    static void Main()
    {
        MethodTeacher methodTeacher = new MethodTeacher();
        double sum = methodTeacher.Sum(3244.34, 2342.1);
        Console.WriteLine($"Sum is {sum}");

        double sumEven = methodTeacher.Sum(2,4,5,6,43);
        Console.WriteLine($"Sum is {sumEven}");
        
    }
    */

    //simple method with 2 arguments and return type
    double Sum( double firstNum, double secondNum)
    {
        DayWeek x;
        return firstNum + secondNum;
    }
    //in this way there can be any number of arguments.
    //params is used to include any number of elements in an array.
   
    public double Sum(params double[] numbers)
    {
        double sum = 0;
        foreach (double num in numbers)
        {
            sum = sum + num;
        }
        return sum;
    }
    public int SumEvens(params int[] nums)
    {
        int sum = 0;

        foreach (int num in nums)
        {
        if( num % 2 == 0)
            sum = sum + num;
        }
        return sum;           
    }

    //returning multiple value ---Using tuples
    // Example: Method to find min and max from set of numbers
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

        return(min, max);
    }

    internal void PrintCustomerDetails(string name, byte age, string address)
    {
        Console.Write($"Name: {name}[{age}], Address: {address}");
    }

   /* public void T Sum<T>(T firstNum, T secondNum)
    {

    }*/
}

public class MethodTester
{
    static void Main()
    {
        MethodTeacher methodTeacher = new MethodTeacher();

        int[] numbers = {34, 28, 56, 23, 67, 45, 4, 6, 10, 89};
        (int, int) result = methodTeacher.FindMinMax(numbers);

        Console.WriteLine($"Minimum:{result.Item1}, Maximum:{result.Item2}");

        //Named-arguments
        methodTeacher.PrintCustomerDetails(age: 22, address: "Bhaktapur", name:"Safal");
    }
}
using System;
using EnumsAndProperties;

public class MethodTeacher
{
    static void Main123()
    {
        MethodTeacher methodTeacher= new MethodTeacher();
        double sum= methodTeacher.Sum (2345.56,2354.7);
        Console.WriteLine($"Sum is {sum}");

    }
    //simple method with 2 argements and a return type
    public double Sum (double firstNum,double secondNum)
    {
        x=DayWeek
    }
    //Variable no of arguments
    public double Sum (params double[] numbers )
    {
        double sum=0;
        foreach (var num in numbers)
        {
            sum=sum+num;

        }
        return sum;
    }
    //Returning multiple value
    //example: Find min and max from set of numbers
    internal (int,int) FindMinMax(int[]numbers)
    {
        int min=numbers[0];
        int max=numbers[0];

        foreach(int num in numbers)
        {
            if(num<min)
               min=num;

            if (num>max)
                max=num;


        }
        return (min,max);

    }
    //generic methods
    public void Sum<T> (T firstNum,T secondNum)
    {
     
    }
    static void Main()
    {
        MethodTeacher methodTeacher= new MethodTeacher();
        int[] numbers ={23,4,5,78,99,6};
        (int Min,int Max)result= methodTeacher.FindMinMax(numbers);
        
        Console.WriteLine($"minimum is {result.Item1},maximum is {result.Item2}");
         methodTeacher.PrintCustomerDetails(age:20, address:"Banesor",name:"Anish");
         methodTeacher.Sum<float>(23.5f,234.78f);

    }
    //named arguements
    internal void PrintCustomerDetails(string name, byte age, string address)
    {
        Console.Write($"Name:{name}[{age}], Address:{address}");
       
    }

}

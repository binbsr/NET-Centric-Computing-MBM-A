using System;
 
public class MethodTeacher
{
   
    public double Sum(double firstNum, double secondNum)
    {
        return firstNum + secondNum;
    }
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


    //returning multiple values-Using tuples
    //example-method to find min and max from set of numbers
    internal (int,int) FindMinMax(int[] numbers)
    {
        int min=numbers[0];
        int max=numbers[0];
        foreach(int num in numbers)
        {
            if(num<min)
            {
                min=num;
            }
            if(num>max)
            {
                max=num;
            }

        }
        return(min,max);
    }

    //Named-Arguements
    internal void PrintCustomerDetails(string name,byte age,string address)
    {
        Console.WriteLine($"name:{name}[{age}] address:{address}");
    }

}

public class MethodTester
{
     static void Main()
    {
        MethodTeacher methodTeacher = new MethodTeacher();
        double sum = methodTeacher.Sum(2345.6, 23452.1);
        Console.WriteLine($"Sum is {sum}");
        // int[] setNumbers = new int[] { };
        double sumEven = methodTeacher.EvenAdder(12, 34, 54, 23, 45, 23, 45, 23);
        Console.WriteLine($"Sum of evens is {sumEven}");
        int[] numbers={34,52,74,13,64,86,53,89};
        (int,int)result=methodTeacher.FindMinMax(numbers);

        Console.WriteLine($"minimum={result.Item1}, maximum={result.Item2}");
        methodTeacher.PrintCustomerDetails(age:32,address:"jhapa",name:"Nischal");
    }
}
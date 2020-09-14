using System;

public class MethodTeacher{
    // simple\
    static void Maind()
    {
        MethodTeacher methodTeacher = new MethodTeacher();
        double sum = methodTeacher.Sum(234.56,32445.2);
        Console.WriteLine($"Sum id {sum}");
    } 
    //simple method with 2 argument and a return type
   public double  Sum (double firstNum ,double secondNum){

        return firstNum + secondNum;

    }
    //variable no. of arguments

    public double  Sum (params double[] numbers){
        double sum = 0;
        foreach(double num in numbers) 
        {
            sum+=num;
        }
        return sum;

    }
    // Returning multipe value - Using tuples
    //Example: Mehod to find min & Max From set of numbers
   internal (int,int ) FindMinMax(int[] numbers)
    {
        int min=numbers[0];
        int max =numbers[0];
        foreach(int num in numbers)
        {
            if(num<min)
            {
                min =num;
            }
            if(num>max)
            {
                max=num;
            }

        }
        return (min,max);
    }
   internal void PrintCustomerDetails(string name,byte age,string address)
    {
        Console.Write($"Name:{name}[{age}],Address: {address}");
    }
    //generic Mehods
    public void   Sum <T> (T firstNum ,T secondNum){

    }

}

public class MethodTester 
 {
     static void Main()
    {
        MethodTeacher methodTeacher = new MethodTeacher();
        int[] numbers = {34,563,45,7,8,90,678,342,435412112,1,0,6,43,4};
        (int min,int max)result = methodTeacher.FindMinMax(numbers);
        Console.WriteLine($"Minimun vlaue {result.min} and maximum value is{result.max}");
        //Named-argument
        methodTeacher.PrintCustomerDetails(age:32,address:"Naikap",name:"Bishnu");
        methodTeacher.Sum<float>(345.34f,4352.34f);
    } 

 }
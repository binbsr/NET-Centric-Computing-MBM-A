using System;

public class MethodTeacher
{

    static void Main1()
    {
        MethodTeacher methodteacher =new MethodTeacher();
       double Sum= methodteacher.Sum(2344.56,5634.98);
       int[] numbers = {1,2,3,4,5,6};
        int sum= Sumofeven1(numbers);
       Console.WriteLine($"The sum is {sum}");
    }

    //simple method :with 2 aruments and return type
    public double Sum(double firstnum,double secondnum)
    {

        return firstnum +secondnum;
    }
    
//method with many arguments
   public static int Sumofeven1(params int[] nums)
   {
     int sum=0;
    foreach(int num in nums)
    {
        if (num%2==0)
        sum =sum+num;
    }
   return sum;
   }
//generic method
 public void   Sum <T> (T firstNum ,T secondNum){
 
{
 
        methodTeacher.Sum<float>(345.34f,4352.34f);

  double Sum(params double[] numbers)
   {
       double sum=0;
       foreach(double num in numbers)
       {
           sum= sum+num;
       }
       return sum;
   }

   //returning multiple value - using tuples
   //example : method to find min and max from the set of numbers
    (int,int) FindMinMax( int[] numbers)
    {
        int min=numbers[0];
        int max=numbers[0];
        foreach(int num in numbers)
        {
            if (num <min)
            min =num;
            if (num >max)
            max=num;
        }
        return (min,max);
    }


void PrintCoustomerDetails(string name,byte age,string address)
    {
        Console.Write($"Name: {name}[{Age}],Address: {address}");
    }
   public  class MethodTester
    {

        static void Main()
        {
            MethodTeacher methodteacher =new MethodTeacher();
            int[] numbers ={ 34,5,6,7,8,9,12};
         ( int Min,int Max)result=  methodteacher.FindMinMax(numbers);


         Console.WriteLine($"Min :{result.Min},Max:{result.Max}");

        }
        methodtester.PrintCoustomerDetails (age :32 ,address:"Naikap", name:"Koka");
        methodteacher.Sum<float> (345.6f,34.56f);
    }


}
using System;
public class MethodTeacher
{
    static void Main3()
    {
        MethodTeacher methodTeacher=new MethodTeacher();
        double sum=methodTeacher.addevens(5,10,15,20,25,30);
        Console.WriteLine($"Sum is {sum}");
    }
    public double sum(double x, double y)
    {
        return x+y;
    }

    public int addevens(int x ,int y , int c ,int d, int e, int f)
    {
       int sum =0;
       if (x%2==0)
       {
           sum+=x;
       }
        if (y%2==0)
       {
           sum+=y;
       }
        if (c%2==0)
       {
           sum+=c;
       }
        if (d%2==0)
       {
           sum+=d;
       }
        if (e%2==0)
       {
           sum+=e;
       }
        if (f%2==0)
       {
           sum+=f;
       }
       return sum;

    }
    //simple method:with 2 arguments and a return type
    public double Sum(double firstnum , double secondnum)
    {
        return firstnum + secondnum;
    }

    // variable-number of arguments

    public double Sum(params double[] numbers)
    {
        double total=0;
        foreach(double num in numbers)
        {
            total+=num;
        }
        return total;
    }

    // Returning multiple value -Using tuples
    //Example: Method to fin min and max from set of numbers
    internal (int,int) FindMinMax(int[] numbers)
    {
        int min=numbers[0];
        int max=numbers[0];
        foreach(int num in numbers)
        {
            if(num < min)
            {
                min=num;
            }
            if(num > max)
            {
                max=num;
            }
        }
        return(min,max);
    }

    public class MethodTester
    {
        static void Main()
        {
            MethodTeacher methodTeacher =new MethodTeacher();

            int[] numbers ={30,25,88,72,06,27};
            (int Min,int Max)result=methodTeacher.FindMinMax(numbers);
            Console.WriteLine($"Mminimum={result.Min},Maximum={result.Max}");
            methodTeacher.PrintCustomerDetails(name:"Rupesh",age:21,adress: "Kapan");
        }
    }

    //Named-Arguments
    internal void PrintCustomerDetails(string name, byte age, string adress)
    {
        Console.WriteLine($"Name:{name},Age:{age},Address:{adress}");
    }
}
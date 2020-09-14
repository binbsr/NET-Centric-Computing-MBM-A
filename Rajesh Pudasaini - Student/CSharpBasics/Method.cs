using System;
using EnumAndDemo;

class MethodTeacher {

    //two argument with a single return
    double Sum(double firstNum, double secondNum){
        return firstNum + secondNum;
    }

    DayWeek x; 

    //can be done with params
    //variable number of argument
    internal int ParamEx(params int[] nums){
        int sum = 0;
        foreach(int num in nums){
            sum += num;
        }
        return sum;
    }
    internal int EvenSum(int[] num){
        int sum = 0;
        for(int i=0; i < 6; i++){
            if (num[i] %2 == 0 ){
                sum = sum + num[i];
            }
        }
        return sum;

    }

    //returnning multiple value - using tuple
    //example: Method to find min and max num from set of numbers
    internal (int, int) FindMinMax(int[] numbers){
        int min=numbers[0], max=numbers[0];
        foreach(int num in numbers){
            if (num < min){
                min = num;
            } else if (num > max){
                max = num;
            }
        }
        return (min, max);
    }

    //named arguments
    internal void PrintCustomerDetail(string name, byte age, string address){
        Console.WriteLine("Name: "+ name);
        Console.WriteLine("Age: " + age);

    }

    //Generic method
    internal void GenericSum<T>(T firstNum, T secondNum){
        Console.WriteLine(firstNum);
        Console.WriteLine(secondNum);
    }
}


class MethodTester{

    static void Main(){
        int[] num = {1, 2, 3, 4, 5, 6}; 
        int[] numbers = new int[] {22, 24, 16};
        MethodTeacher obj1 = new MethodTeacher();
        int res = obj1.EvenSum(num);
        int res2 = obj1.ParamEx(1, 2, 3, 4);
        (int Min, int Max) result = obj1.FindMinMax(numbers);
        obj1.PrintCustomerDetail(name:"Rajesh", address:"Kapan", age:21);
        obj1.GenericSum<float>(1.2f, 2.2f);
        Console.WriteLine(result);
        Console.WriteLine($"Minimum: {result.Min}, Maximum: {result.Max}");
        Console.WriteLine(res2);
        Console.WriteLine(res);
    }
}
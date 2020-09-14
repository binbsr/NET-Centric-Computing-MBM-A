using System;

class MethodTeacher {

    //two argument with a single return
    double Sum(double firstNum, double secondNum){
        return firstNum + secondNum;
    }

    
    //can be done with params
    //variable number of argument
    int ParamEx(params int[] nums){
        int sum = 0;
        foreach(int num in nums){
            sum += num;
        }
        return sum;
    }
    int EvenSum(int[] num){
        int sum = 0;
        for(int i=0; i < 6; i++){
            if (num[i] %2 == 0 ){
                sum = sum + num[i];
            }
        }
        return sum;

    }


    //Returning multiple values -Using tupes
    // Example: Methiod to find min and max from a set of numbers

    internal (int, int) FindMinMax(int[] numbers){
        int min = numbers[0];
        int max = numbers[0];

        foreach(int num in numbers){
            if(num < min)
                min = num;
            if(num > max)
                max = num;
        }

        return(min, max);
    }

     // Named Arguments

    internal void PrintCustomerDetails(string name, byte age,string address){
        Console.WriteLine($"Name: {name}, Age: [{age}], Address: {address}");
    }

    //Generic Methods
    
}

public class MethodTester{
    static void Main(){
        
        MethodTeacher methodTeacher = new MethodTeacher();
        int[] numbers = {12,26,35,65,45,25,66,35,25,64,68};

        (int min,int max) result = methodTeacher.FindMinMax(numbers);
        Console.WriteLine($"Minimum: {result.min}, Maximum: {result.max}");
    
        // Named Arguments
        methodTeacher.PrintCustomerDetails(age:32,address: "Nepal", name: "Bibek");
    }

   


}
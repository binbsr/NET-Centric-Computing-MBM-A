//Question : Given two numbers, write C# method that returns true if sum of both numbers is greater than 500. Otherwise returns false.

using System;

class CheckSum {
    internal void Execute(){
        Console.WriteLine("\n\n\n\n#######-------Question 1-------#######");
        CheckSum obj1 = new CheckSum();
        int num1 = obj1.ReturnUserInput();
        int num2 = obj1.ReturnUserInput();
        bool res = obj1.CheckSum500(num1, num2);
        Console.WriteLine(res);
    }

    //method to check if sum is greater than 500 or not
    bool CheckSum500(int num1, int num2){
        if (num1 + num2 > 500){
            Console.WriteLine($"The Sum of {num1} and {num2} is greater than 500");
            return true;
        }
        else {
            Console.WriteLine($"The Sum of {num1} and {num2} is equal or less than 500");
            return false;
        }
    }

    //method to take user input
    int ReturnUserInput(){
        Console.Write("Enter Input(int): ");
        int num1 = Int32.Parse(Console.ReadLine());
        return num1;
    }
}
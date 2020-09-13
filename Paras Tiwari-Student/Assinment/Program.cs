using System;

namespace Assinment
{
    class Program
    {
        static void Main(string[] args)
        {
            Method method1 = new Method();
            Console.WriteLine("Enter First Number");
            int num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2=  int.Parse(Console.ReadLine());
            bool result= method1.SumOfNum(num1,num2); //calling first method
            if (result)
            {
                Console.WriteLine($"Sum of {num1} and {num2} is greater than 500 so result is {result}");
            }
            else
            {
                Console.WriteLine($"Sum of {num1} and {num2} is not greater than 500 so result is {result}");
            }
        }
    }
}

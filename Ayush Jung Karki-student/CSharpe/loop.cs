using System;

 public class Sum{

  static void Main(string[]args){
int a,b,output;

//taking first number
System.Console.WriteLine("Enter first number:");
a=Convert.ToInt32(Console.ReadLine());

//taking second number
System.Console.WriteLine("Enter second number:");
b=Convert.ToInt32(Console.ReadLine());


output=a=b;
if(output>500)
{
System.Console.WriteLine("Accepted");
}
else{
System.Console.WriteLine("Rejected");

}
  }
}
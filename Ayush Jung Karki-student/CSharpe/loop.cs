using System;

 public class Sum{

  static void Main(string[]args){
Operation operation=new Operation();

//taking first number
System.Console.WriteLine("Enter first number:");
int a=int.Parse(Console.ReadLine());

//taking second number
System.Console.WriteLine("Enter second number:");
int b=int.Parse(Console.ReadLine());


bool output=operation.SumOfTwoNum( a,b);

if(output){
  System.Console.WriteLine($"sum of given number is greater than 500 and result is: {output}");
}
else{
  
  System.Console.WriteLine($"sum of given number is less than 500 and result is: {output}");

}

//score problem

System.Console.WriteLine("Enter number of wins: ");
int wins=int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter number of draws: ");
int draws=int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter number of losses: ");
int losses=int.Parse(Console.ReadLine());

int result= operation.CalculatePoint(wins,draws,losses);

System.Console.WriteLine($"The number of points of calculated football team is:{result}");


//Concatination of Strings

System.Console.WriteLine("Enter a string:");
string word=Console.ReadLine();
string initial=operation.GetInitials(word);
System.Console.WriteLine($"the initial character of given word is:{initial}");

  }

}
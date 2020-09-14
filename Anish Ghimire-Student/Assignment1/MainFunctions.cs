using System;

//Main for SumOfIntegers
class Programs
{
    static void Main()
    {
        Console.WriteLine("Enter First numbers:");
        int num1=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Second Number:");
        int num2=int.Parse(Console.ReadLine());

        int Add=num1+num2;
        SumOfIntegers SI= new SumOfIntegers();
        Console.WriteLine(SI.Sum(Add));


        //Main for Footballresults
        FootballResult footballResult= new FootballResult();
        Console.WriteLine($"The total points obtainedis:{footballResult.Resultvar()}");
         
         //Main for StringInitials
         StringInitials SOI= new StringInitials();
         SOI.NameInitials();
         



    }
}
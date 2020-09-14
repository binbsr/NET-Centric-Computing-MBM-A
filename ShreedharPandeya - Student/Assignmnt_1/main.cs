//Driver program for all of above questions

using System;

class program{

 static void Main(){

            //main for question1
            MethodSum MS = new MethodSum();
            Console.WriteLine("Enter 1st number :");
            String x = Console.ReadLine();
            int a = int.Parse(x);

            Console.WriteLine("Enter 2nd number: ");
            string y = Console.ReadLine();
            int b = int.Parse(y);

            int z = a + b;

            Console.WriteLine(MS.num(z));

            //MAin for question 2
            PointSystem PS = new PointSystem();
            Console.WriteLine($"The total points is {PS.WDL()}");

            //Main for question 3
            Abbre ab = new Abbre();
            ab.Initials();

           







        }


}
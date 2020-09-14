using System;

class Program
{
    static void Main()
    {
        // 1.
        SumChecker sumChecker = new SumChecker();
        bool result = sumChecker.Number(x, y);
        Console.WriteLine($"{result}");

        // 2.
        PointCalc pointCalc = new PointCalc();
        Console.WriteLine($"Total points: {pointCalc.Points()}");

        //3.
        StrConcatinate strConcatinate = new StrConcatinate();
        Console.WriteLine($"{strConcatinate.GetInitials()}");
    }
}
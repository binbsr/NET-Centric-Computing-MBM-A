using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum();
            sum.SumMethod();
            PointTable point = new PointTable();
            Console.WriteLine("Enter the win, draw and loss number of team :");
            int win = int.Parse(Console.ReadLine());
            int draw = int.Parse(Console.ReadLine());
            int loss= int.Parse(Console.ReadLine());
            int totalPoints;
            totalPoints = point.GameStatus(win,draw,loss);
            Console.WriteLine($"win  \t draw  \t  loss \t totalpoints  \n{win} \t {draw} \t {loss} \t {totalPoints}" );
            Concate concate = new Concate();
            Console.WriteLine("Enter sentence");
            String word = Console.ReadLine();
            String result = concate.GetInitials(word);
            result = result.ToUpper();
            Console.WriteLine($"new concated string is:{result}");
        }
    }
}

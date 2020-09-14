using System;

class Qsn1
{
    static void Main1()
    {
        Qsn1 answer=new Qsn1();
        answer.Sum();
    }
     void Sum()
  {
    Console.Write("Input first number: ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Input second number: ");
    int y = int.Parse(Console.ReadLine());
    bool test =x + y > 500;
    Console.WriteLine($"Result: {test}");
  }
}
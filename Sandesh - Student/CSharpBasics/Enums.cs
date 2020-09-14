
using System;

enum DayOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wenesday,
    Thursday,
    Friday
}
internal class Demo
{
    public string DayOfWeek{get; set;}
    
    void PrintGreetings()
    {
        if (DayOfWeek == "DayOfWeek.Sunday")
        {
            Console.WriteLine("alxi lago my lord");
        }
        else if (DayOfWeek == "DayOfWeek.Monday")
        {
            Console.WriteLine("Jagar Lagena my lord");
        }
        else
        {
            Console.WriteLine("teti energy xaina");
        }
    }
}
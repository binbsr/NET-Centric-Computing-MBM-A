using System;

namespace Name
{
    
}

enum DayWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}


internal class Demo
{
    public DayWeek DayWeek{ get; set; }


    void PrintGreetings()
    {
        if(DayWeek == DayWeek.Sunday )
        {
            Console.WriteLine("Sunday is a good day");
        }
            else if (DayWeek == DayWeek.Saturday)
        {
            Console.WriteLine("Saturday is a holiday");
        }
        else{
            Console.WriteLine("Fuck this day");
        }
    }
}
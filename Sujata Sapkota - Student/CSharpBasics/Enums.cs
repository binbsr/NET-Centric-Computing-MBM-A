using System;

namespace EnumsAndProperties
{
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
    
    public DayWeek DayWeek {get; set;}
    void PrintGreetings()
    {
        if(DayWeek == DayWeek.Saturday)
        {
            Console.WriteLine(" It is good");
        }
         else if(DayWeek == DayWeek.Sunday)
        {
            Console.WriteLine(" It is very good");
        }
         else
        {
            Console.WriteLine(" It is not good");
        }
    }
}
}
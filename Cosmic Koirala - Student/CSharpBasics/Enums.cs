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
    public DayWeek DayofWeek {get; set;}
    void PrintGreetings()
    {
        if(DayofWeek == DayWeek.Saturday)
        {
            Console.WriteLine(" It is good");
        }
         else if(DayofWeek == DayWeek.Sunday)
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
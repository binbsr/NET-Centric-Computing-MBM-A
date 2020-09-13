using System;
enum DayofWeek{
    Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday

        }
internal class Demo
{
    public DayofWeek DayofWeek{ get ; set;}
    void PrintGreetings()
    {
        
        if(DayofWeek == DayofWeek.Saturday)
        {
            Console.WriteLine("Its a good Saturday");

        }
        else if (DayofWeek == DayofWeek.Sunday)
        {
            Console.WriteLine("Its yet another weekend day.");
        }
        else
        {
            Console.WriteLine("Its a work day");
        }
    }
}
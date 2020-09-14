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
    public DayWeek DayWeek { get; set; }
    void printGreetings()
    {

        if (DayWeek == DayWeek.Saturday)
        {
            Console.WriteLine("its a good saturday");
        }
        else if (DayWeek == DayWeek.Sunday)
        {
            Console.WriteLine("Its a holiday");

        }
        else
        {
            Console.WriteLine("oh its a work day");

        }
    }
}




}
using System;

namespace EnumsAndProperties{
    enum DayOfWeek
{
    Sunday,Monday,Wednesday,Thursday,Friday,Saturday 
}
internal class Demo{

    public  DayOfWeek DayOfWeek{ get; set;}
        void PrintGreetings()
        {
           
            if(DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("Its a good saturday");
            }
            else if(DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Its yet another weekend day.");
            }
            else
            {
                Console.WriteLine("Oh! gosh, Work day.");
            }
        }
}

}

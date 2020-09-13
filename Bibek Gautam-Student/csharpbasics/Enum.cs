using System;

namespace EnumsAndProperties
{


    enum DayOfWeek
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
    internal class Demo
    {

        internal DayOfWeek dayOfWeek;

        void PrintGreetings()
        {


            if (dayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("its sundays");
            }
            else if (dayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("its monday");
            }
            else
            {
                Console.WriteLine("Got Busy day");
            }
        }


    }

}
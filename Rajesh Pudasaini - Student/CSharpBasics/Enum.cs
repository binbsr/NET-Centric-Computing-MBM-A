using System;

namespace EnumAndDemo
{

    enum DayWeek
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
    internal class Demo
    {

        internal DayWeek dayOfWeek;

        void PrintGreetings()
        {


            if (dayOfWeek == DayWeek.Sunday)
            {
                Console.WriteLine("its sundays");
            }
            else if (dayOfWeek == DayWeek.Monday)
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
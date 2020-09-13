using System;

namespace AllAboutClasses
{
    public class Country
    {

        public string Name{get; set;}

        public int Population{get; set;}

        public const double Area = 12312;

        //Default Constructor
        public Country()
        {

        }

        //Paramaterized Constructor
        public Country(string name, int population, double area)

        {
            Name = name;
            Population = population;
            Area = area;


        }




    }

    public class Demo{

        void DoSomething()
        {
            Country country = new Country();
            Country country1 = new Country("Nepal");

        }
    }



}
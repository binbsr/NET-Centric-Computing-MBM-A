namespace AllAboutClass
{
    public class Country
    {
        public string Name { get; set;}

        public int population {get; set;}

        public const double AREA =34343.454;
        //default constructor
        public Country()
        {

        }
        
        //Parameterized constructor
        public Country(string name)
        {
            Name =name;
        }

        public Country(string name, int population, double area)
        {
            Name= name;
            Population =population;
            AREA=area;
        }
    }

    public class Demo
    {
        void DoSomething()
        {
            Country country1 =new Country();
            Country country2 =new Country("Nepal");
        }
    }
}


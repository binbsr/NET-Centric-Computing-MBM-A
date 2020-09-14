namespace AllAboutClasses
{
    public class Country
    {
        public string Name { get; set; }

        public int Population { get; set; }

        public readonly double AREA = 45451.2;


        //Default Constructor
        public Country()
        {

        }

        // Parametrized Constructor

        public Country(string name)
        {

        }

        public Country(string name, int population, double area)
        {
            Name = name;
            Population = population;
            AREA = area;
        }
    }

    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country country2 = new Country("Nepal");
        }
    }
}
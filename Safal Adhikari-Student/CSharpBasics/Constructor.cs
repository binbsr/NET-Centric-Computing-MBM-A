namespace AllAboutClasses
{
    public class Country
    {
        //Default constructor
        public string Name{ get; set; }
        public int Population { get; set; }
        public readonly double AREA = 43443.45;

        public Country()
        {
           
        }

        public Country(string name)
        {
           Name = name;
        }
        // Parameterized constructor
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
            Country country = new Country();
            Country country1 = new Country("Nepal");

        }
    }
}
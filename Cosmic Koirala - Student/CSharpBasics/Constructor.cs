namespace AllAboutClasses
{
    public class Country
    {
        public string Name { get; set;}
        public int Population { get; set; }

        public readonly double AREA = 45678.23;
        public Country()
        {

        }

       

        public Country(string name, int population, double area)
        {
            Name = name;
            Population = population;
            AREA = area;
        }
        // Parameterized Constructor

        public Country(string name)
        {
            Name = name;
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
namespace AllAboutClasses
{
    public class Country
    {
        //Defaullt Constructor
        public string Name {get; set;}
        public int Population {get; set;}
        public readonly double Area = 445854.587;
        public Country()
        {

        }
        public Country(string name)
        {
            Name = name;
        }
        //Parameterized Constructor
        public Country(string name, int population, double area)
        {
            Name = name;
            Population = population;
            Area = area;
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
namespace AllAboutClasses
{
    public class Country
    {

        public string name { get; set; }
        public int area { get; set; }
        //default constructor
        public Country()
        {

        }

        //parameterized constructor
        public Country(string country)
        {
            name = country;
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
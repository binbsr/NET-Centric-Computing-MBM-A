namespace AllAboutClasses
{
    public class Country
    {
        //Default Constructor
       public string Name{get;set;}
       public int Population{get;set;}
       public double Area {get;set;}

        public Country()
        {

        }
        //Parameterized constructor
        public Country(string name)
        {
            Name=name;

        }
        public Country(string name,int population,double area)
        {
            Name=name;
            Population=population;
            Area=area;
        }
    }
    public class Demo
    {
        void DoSomething()
        {
            Country country1= new Country();
            Country country2=new Country("Nepal");
        }
    }
}
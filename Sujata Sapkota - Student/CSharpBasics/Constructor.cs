namespace AllAboutClasses
{
  public class Country
  {
      public string Name {get; set;}

      public double Population {get; set;}
      public readonly double AREA = 43443.45;
      public Country()
      {
          
      }
      //parameterized constructor
      public Country(string name)
      {
        Name = name;
      }
      public Country(string name, int population, double area)
      {
          Name = name;
          Population = population ;
          AREA = area;
      }
  }
  public class Demo
  {
      void Dosomething()
      {
          Country country1 = new Country();
          Country country2 = new Country("Nepal");
      }
  }
}
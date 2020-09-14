namespace AllAboutClasses{
    public class Country{

        public string Name { get; set; }

        public int Population { get; set; }

        public const double AREA = 42541.3232;
        //default constructor
        public Country(){

        }

        //Parameterized Constructor
        public Country(string name){

        }


        public Country(string name, int populatoin, double area){
            Name = name;
            Population = populatoin;
            
            
        }
    }

    public class Demo{
        void DoSth(){
            Country country1 = new Country();

            Country country2 = new Country("Nepal");

        }
    }
}
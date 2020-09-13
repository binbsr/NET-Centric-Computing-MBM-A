namespace AllAboutClasses {

    public class Country {


        public const double AREA = 1.23;

        //property
        public string Name {
            get; set;
        }

        //default constructor
        public Country(){

        }

        //Parameterized constructor
        public Country(string name){

        }

        public Country(string name, int population, double area){
            Name=name;

        }
    }

    public class Demo {

        static void Main(){
            Country country1 = new Country();//call the constructor without argument
            Country country2 = new Country(); //call the constructor with argument

        }
    }
}
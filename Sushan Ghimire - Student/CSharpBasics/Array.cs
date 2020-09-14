class Array
{
    void Learn1DArray()
    {
        int[] ages1 = new int[10]; //this is how we define array
        double[] ages2 = new double[10];

        ages1[0] = 55; //this is how we initialize values in array
        ages1[5] = 20;

        float[] numbers = new float[] {23.4f, 45.6f, 29.2f}; //this is another way of assigning values in array whose size is known automatically
        float[] numbers1 = {23.4f, 45.6f, 29.2f}; //alternate way of defining array
    }

    void LearnMulDArray()
    {
        //2D array
        int[,] agesMatrix = new int[10, 15]; //this is how we define 2D array
        agesMatrix[0, 0] = 45; //assigning value to matrix (2D array)

        //3D array
        int[,,] agesMatrix3D = new int[10, 15, 5]; 
        string[,] names = new string[,] {{"Ram", "Dahal"}, {"Shyam", "Karki"} }; //initialize data
        string[,] names1 = {{"Ram", "Dahal"}, {"Shyam", "Karki"}}; //alternate way 

        //23,45,67,87
        //55,85,98,87
        //78,89,88,99
        //We use multi dimensional array for this conditions where elements in rows are equal

        //23,45,67,87
        //55,85,98
        //78,89,88,99
        //For such elements where elements of rows are not equal, we use jagged array
    }
    void LearnJaggedArray()
    {
        byte [][] personAges = new byte[3][]; //we don't use byte[3][3] because number of elements in a row varies
        personAges[0] = new byte[] {34, 56}; //first row with 2 elements
        personAges[1] = new byte[] {34, 56, 55, 57};//second row with 4 elements
        personAges[2] = new byte[] {34, 55}; //third row with 2 elements
    }    
}
class Array
{
    void Learn1DArray()
    {
        int[] ages1 = new int[10];
        double[] ages2 = new double[10];
    
        ages1[0] = 34;
        ages1[5] = 4;

        float[] numbers = new float[] {23.4f, 45.6f, 12.34f};
        float[] numbers1 ={23.4f, 45.6f, 12.34f};

    }


    void learnMulDArray()
    {
        //2-D array
       int[,] agesMatrix = new int[10, 15];
       agesMatrix[0, 0] = 4567;

       int[,,] agesMatrix3D = new int[10, 15, 5];

       string[,] names = new string[,] { {"Bishnu", "Rawal"},{"Ram", "lal"} };
       string[,] names1 ={ {"Bishnu", "Rawal"},{"Ram", "lal"} };

       //23,45,67,87
       //23,15,87,84
       //22,45,60,87

    }
    void LearnJaggedArray()
    {
        byte[][] personAges = new byte[3][];
        personAges[0] = new byte[] { 34, 56};
        personAges[1] = new byte[] { 34, 56, 23, 45, 67};
        personAges[2] = new byte[] { 34, 56, 23};
        
           
    }

}
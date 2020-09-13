class Array
{
    void Learn1DArray()
    {
        int[] ages1 =new int[10];
        double[] ages2 = new double[10];

        ages1[0] = 34;
        ages1[5] = 4;

        float[] numbers= new float[]{23.4f,45.6f};
        float[] numbers1={34.5f,56.7f,3.6f};
    }

    void LearnMulArray()
    {
        //2-D array
        int[ , ] agesMatrix =new int[10,15];
        agesMatrix[0,0]= 4567;
            
        //3-D array
        int[,,] agesMatrix3D= new int [10 ,15,16];

        string[,] names =new string[,]{{"Kushal","Kattel"},{"Rupu","Chaulagain"}};
        string[,] names1 = {{"Kushal","Kattel"},{"Rupu","Chaulagain"}};

    }

    void LearnJaggedArray()
    {
        byte[][] personAges= new byte[3][];
        //second parameter shouldnot be defined for jagged array
        personAges[0] =new byte[] {34,56};
        personAges[1] = new byte[] { 34,56,23,45,67};
        personAges[2] =new byte[] { 34 ,56, 23 };
    }
}
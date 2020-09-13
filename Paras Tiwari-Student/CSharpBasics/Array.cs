class Array
{
    void Learn1DArray()
        {
            int[] ages1 = new int[10];
            double[] ages2= new double[10];
            ages1[0]=34;
            ages2[5]= 4;

            float[] numbres = new float[]{23.4f,45.6f,12.34f};
            float[] numbres1= new float[]{23.4f,45.6f,12.34f};
        }
    void LearnMUlDArray()
    {
        //2-D array
        int[,] agesMatrix = new int[10,15];
        agesMatrix[0,0]= 4567;

        //3-D array
        int[,,] agesMatrix3D = new int [ 10,15,5];

        string[,] names = new string[,] { {"Bishnu","Rawal"},{"Ram","Basnet"} };
        string[,] names1= new string[,] { {"Bishnu","Rawal"},{"Ram","Basnet"} };


    
    }
    void LearnJaggedArray()
    {
        byte[][] personAges= new byte[3][];
        personAges[0]= new byte[] {34,56};
        personAges[1]= new byte[] {34,56,23,45,76};
        personAges[2]= new byte[] {34,56,23};
    }


}
    

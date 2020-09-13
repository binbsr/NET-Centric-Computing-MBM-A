class Array
{
    void learn1DArray()
    {
        int[] ages = new int[10];
        double[] ages2 = new double[10];

        float[] numbers = new float[] {23.4f, 43.2f, 32.23f};
        float[] numbers1 = {23.4f, 43.2f, 32.23f};

    }

    void learnMulDArray()
    {
        //simply putting comma in square brackets makes multi dimensional array.
        int[,] agesMatrix = new int[10, 15];
        agesMatrix[0,0] = 237;

        int[,,] agesMatrix3D = new int[10, 15, 5];
        
        string[,] names = new string[,] { {"Safal", "Adhikari"}, {"James", "Bond"} };
        string[,] names1 = { {"Safal", "Adhikari"}, {"James", "Bond"} };

    
    }
        // 23,54,67,32
        // 56,34,90
        // 24,86,83,63
        void LearnJaggedArray()
        {
            byte[][] personAges = new byte[3][];
            personAges[0] = new byte[]{ 34, 56};
            personAges[1] = new byte[]{ 34, 56, 45, 76, 34};
            personAges[0] = new byte[]{ 34, 56, 46};


        }
}
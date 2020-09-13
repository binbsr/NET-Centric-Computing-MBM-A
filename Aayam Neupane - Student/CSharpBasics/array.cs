class Array
{
    void Learn1DArray()
    {
        int[] ages1 = new int[10];
        double[] ages2 = new double [10];

        ages1[0] = 34;
        ages1[2] = 4;
        
        float[] numbers = new float[] {23.4f, 45.6f, 12.34f};
        float[] numbers1 = {23.4f, 45.6f, 12.34f};
    }
    
    void LearnMulDArray()
    {
        int[,] agesMatrix = new int[10,15];
        agesMatrix[0, 0] = 6543;
        int[,,] agesMatrix3D = new int[10, 65, 47];
        string[,] names= new string[,]{{"Aayam","Neupane"},{"PP","PooPoo"}};
    }

    void LearnJaggedArray()
    {
        byte[][] personAges = new byte[3][];
        personAges[0] = new byte[]{34, 68};
        personAges[0] = new byte[]{34, 68, 84, 46};
        personAges[0] = new byte[2]{34, 68};

    }
}

class Array
{

    void Learn1DArray()
    {
        int[] ages = new int[10];
        double[] ages2 = new double[10];

        ages[0] = 34;
        ages2[5] = 11.5;

        float[] numbers = new float[] { 23.4f, 45.6f, 34.4f, 324.5f };
        float[] numbers1 = { 23.4f, 45.6f, 34.4f, 324.5f };
    }

    void LearnMulDArray()
    {
        int[,] agesMatrix = new int[10, 15];
        agesMatrix[0, 0] = 3452;

        int[,,] agesMatrix3D = new int[10, 15, 5];

        string[,] name = new string[,] { { "Utsav", "Kuinkel" }, { "Upasana", "Kuinkel" } };
        string[,] name2 = { { "Utsav", "Kuinkel" }, { "Upasana", "Kuinkel" } };
    }

    void LearnJaggedArray()
    {
        byte[][] trueOrFalse = new byte[3][];
        trueOrFalse[0] = new byte[] { 1, 0 };
        trueOrFalse[1] = new byte[] { 1, 0, 0, 1, 1 };
        trueOrFalse[2] = new byte[] { 0, 0, 1, 1, 0, 1, 0, 1, 1 };
    }
}
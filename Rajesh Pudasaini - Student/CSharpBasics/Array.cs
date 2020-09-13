class Array {
    void Learn1DArray(){
        //definning single array in c sharp
        int[] ages1 = new int[10];
        double[] ages2 = new double[10];

        ages1[0] = 1;
        ages1[5] = 2;

        float[] numbers = new float[] {1.2f, 3.5f};
        float[] numbers1 = {1.4f, 6.1f};
    }

    void LearnMultiArray(){
        //two dimensional array
        int[,] agesMatrix = new int[10, 15];
        agesMatrix[0, 0] = 1; //assigning value in two dimensional array

        int[,,] agesMatric3D = new int[10, 15, 20]; //hold 10 items, and each item itself has 15 row and 20 column
        string[,] names = new string[,] {{"Rajesh", "Pudasaini"}, {"Rajendra", "Pudasaini"}};
    }

    void LearnJaggedArray() {
        byte[][] personAges = new byte[3][];
        personAges[0] = new byte[] {34, 56};
        personAges[1] = new byte[] {34, 56, 23, 45, 67};
        personAges[2] = new byte[] {1, 2, 3};
    }
}
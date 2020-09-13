class array{

    void Learn1DArray(){
        int[] ages = new int[10];
        double[] agesDouble = new double[10];

        ages[0] = 25;
        ages[5] = 132;

        float[] numbers = new float[] {2.3f, 11.65f,7.3f};
        float[] numbers2 = {32.15f, 12.25f};

    }

    void LearnMultiarray(){
        //2D Array/matrix
        int[,] ageMatrix = new int[2,2];
        ageMatrix[0,0] = 23;
        ageMatrix[2,2] = 25;

        string[,] name = new string[,] {{"Bibek", "Gautam"},{"Andrew","Scott"}};

        //3D array
        int[,,] arr1 = new int[2,2,2];
     }

     void LearnJaggedArrays(){
         byte[][] personAge = new byte[3][];
         personAge[0] = new byte[]{35,26};
         personAge[1] = new byte[]{36,25,48};
         personAge[2] = new byte[]{36,55,58,41};
     }
}
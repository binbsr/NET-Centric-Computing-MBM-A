class Array
{
    void Learn1DArray()
    {
        int[] ages1=new int [10];
        double[] ages2=new double [10];
        ages1[0]=43;
        ages1[4]=22;
        float[] numbers=new float[]{21.4f, 45.6f,12.14f};
        float[] numbers1={23.4f,45.6f,23.43f};

    }
    void LearnMulDArray()
    {
        int[,] agesMatrix=new int[10,15];
        agesMatrix[0,0]=4567;
        int[,,] agesMatrix3D=new int[10,15,5];
        string[,] name=new string[,]{{"anjali", "Neupane"},{"Ram","basnet"}};
        string[,] name2={{"anjali", "Neupane"},{"Ram","basnet"}};
    }
    
    void LearnJaggedArray()
    {
        byte[][] personAges=new byte[3][];
        personAges [0]= new byte[2]{34,56};
        personAges [1]= new byte[2]{3,56};
        personAges [3]= new byte[2]{34,5};
        
        

    }
}
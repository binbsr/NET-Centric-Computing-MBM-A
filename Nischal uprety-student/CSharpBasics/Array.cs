

class array
{
    void Learn1Darray()
    {
        int [] ages1 = new int[10];
        double [] ages2 = new double[10];

        ages1[0]=34;
        ages1[5]=12;

        float[] num1=new float[] {23.4f,32.6f,21.9f};
        float[] num2={23.4f,32.6f,21.9f};

    }

    void LearnMulDarray()
    {
        int [,] agesmatrix = new int[10,15];
        agesmatrix[0,0]=12;

        int [,,] agesmatrix3D = new int[10,15,5];

        string[,] names = new string[,] {{"Nischal","uprety"},{"Utsav","kuinkel"}};
        string[,] names1 = {{"Nischal","uprety"},{"Utsav","kuinkel"}};

    }

    void LearnJaggedarrays()
    {
        //23,24,25,54
        //12,35,67
        //11,23,34,35,46
        byte[][] personAges =new byte[3][];
        personAges[0] = new byte[4] {23,24,25,54};
        personAges[1] = new byte[3] {12,35,67};
        personAges[2] = new byte[5] {11,23,34,35,46};



    }
}
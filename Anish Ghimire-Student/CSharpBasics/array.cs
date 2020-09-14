using System;
class Array
{
    void learn1DArray()
    {
        int[] ages1= new int[10];
        double[] ages2=new double[10];
       
        ages1[0]=34;
        ages1[5]=4;

        float[] numbers = new float[]{23.4f, 67.8f,5f};
        float[] numbers1={23.4f, 67.8f,5f};






    }
    void learnMultiArray()
    {
        //2d array
       int[,] agesmatrix= new int[10,15]; 
       agesmatrix[0,0]=2389;


       //3d array
       int[,,] agesmatrix3D= new int[10,15,5]; 

       string[,] names = new string[,] {{"Anish", "Ghimire"},{"Aayam" ,"neupane"}};


       //23,45,67,87
       //23,13,34,
       //21,32,45,69
    }
    void learnJaggedarray()
    {
        byte[][]personAges= new byte[3][];
        personAges[0]=new byte[2]{34,56};
        personAges[1]=new byte[]{34,56,23,56,78};
        personAges[2]=new byte[]{34,56,66};



    }
}
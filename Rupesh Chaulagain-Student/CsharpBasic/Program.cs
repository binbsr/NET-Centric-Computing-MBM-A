using System;


    class Array
    {
       void learn1Darray()
       {
           int[] ages1= new int[10];
           double[] ages2= new double[10];

           ages1[0]=34;
           ages1[5]=4;

           float[] numbers= new float[] {23.4f,55.7f};
           float[] numbers1= {23.4f,55.7f,45.3f};
       }

       void learnmulDarray()
       {
           //2-d array
           int[,] agesmatrix= new int[10,15];
           agesmatrix[0,0]=456;

           int[,,]agesmatrix3d =new int[10,15,5];

           string[,]names=new string[,]{{"rupesh","chaulagain"},{"Ram","bahadur"}};
           string[,]names1={{"rupesh","chaulagain"},{"Ram","bahadur"}};
       }


    

        void learnJaggedArray()
        {
            byte[][] personAges=new byte[3][];
            personAges[0]=new byte[] {33,56,65};
            personAges[1]=new byte[] {34,56};
            personAges[2]=new byte[] {23,46,44,65};
        }
    }





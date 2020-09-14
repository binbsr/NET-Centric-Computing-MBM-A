using System;
class Array{
void Learn1DArray()
{
    int[] ages1 = new int[10];
    double[] ages2 = new double[10];
    ages1[0] = 32;
    ages1[5] = 4;
    float[] numbers = new float[] {23.4f, 45.6f, 12.34f};
    float[] nummbers1 = {23.4f, 46.7f,12.11f};
}
void LearnMU1DArray(){
    int[,] ageMatrix = new int[10,15];
    ageMatrix[0,0] = 2345;
    int[,,] ageMatrix3d = new int[10, 15, 5];
    ageMatrix3d[0,0,1] = 123;
    string[,] names = new string[,] {{"Hello", "ram"},{"what","dahek"}};


}
void LearnJaggedArray()
{
    byte[][] Ages = new byte[3][];
    Ages[0] = new byte[] {32,23};
    Ages[1] = new byte[] {11,113,34,56};
    Ages[2] = new byte[] {1};


    



}
}
using System;
public class Method{
    public double Sum (double x, double y){
        return x+y;

    }
internal (int,int) FindMinMax (int[] number)
{
      int min = number[0];
      int max = number[0];
      foreach(int n in number){
          if(min>n)
          min = n;
          if (max<n)
          max=n;
          

      }

}
}
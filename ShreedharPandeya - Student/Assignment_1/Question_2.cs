//  Create a function that takes the number of wins, draws and losses, and calculates
// the number of points a football team has obtained so far.
// wins get 5 points
// draws get 2 point
// losses get 0 points

using System;

public class PointSystem {

   
    public int WDL() {
         
            Console.Write("Enter number of wins: ");
            String W = Console.ReadLine();
            int w = int.Parse(W);

            Console.WriteLine("Enter number of Draws: ");
            String D = Console.ReadLine();
            int d = int.Parse(D);

            Console.WriteLine("Enter number of loses: ");
            String L = Console.ReadLine();
            int l = int.Parse(L);

            return (w*5 + d*2 + l*0);


    }
    
    


}
using System;
public class PointTable{
    internal int GameStatus(int win, int draw, int loss){
         return (win*5+draw*2+loss*0);
        
    }
}
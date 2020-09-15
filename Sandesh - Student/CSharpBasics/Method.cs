class Method{




//     1. Given two numbers, write C# method that returns true if sum of both 
// numbers is greater than 500. Otherwise returns false.
     internal bool SumOfNum( int num1 , int num2)
     {
         int sum = num1 + num2;
         if(sum>500)
            return true;
        else
            return false;
    }
//      1. Create a function that takes the number of wins, draws and losses, and calculates
// the number of points a football team has obtained so far.
// wins get 5 points
// draws get 2 point
// losses get 0 points

internal int PointsCalulator(int wins ,int draws,int losses){
    
    return(wins*5+ draws*2 + losses*0);

}
// 1. Creates a function that takes a two word string separated by space and returns the concatenated first characters of both the words.
// E.g. 
// GetInitials("Bishnu Rawal") => "BR"
// GetInitials("Alex Wales") => "AW"
internal string GetInitials(string name)
{
    string initial="";
    int len = name.Length;
    int i=0;
    while(i<len)
    {
        if(i==0)
        {
            initial+= name[i];
        }
        else if (name[i]== ' ')
        {
            initial+= name[i+1];
        }
    i++;

    }
     return initial.ToUpper();
    


}
}
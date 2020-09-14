class Method{
     internal bool SumOfNum( int a , int b)
     {
         int sum = a + b;
         if(sum>500)
            return true;
        else
            return false;
    }
    internal int PointsCalculator(int wins ,int draws,int losses){
    
    return(wins*5+ draws*2 + losses*0);
}
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
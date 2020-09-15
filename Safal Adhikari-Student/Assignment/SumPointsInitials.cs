//program that returns true if the sum of two given input is greater than 500, else returns false.
class All
{
    internal bool SumChecker (int firstNum, int secondNum)
    {
        if (firstNum + secondNum > 500)
            return true;
        else
            return false;
    }


    //function that takes wins, draws and losses and calculates the total points
    internal int WinDrawLoss (int win, int draw, int loss)
    {
        return (win*5 + draw*2 + loss*0);
    }

    //fuction that takes two words and returns the concatenated result of the initials of two words.

    internal string StringConcatenation (string words)
    {

    string initialLetter= "";
    int length = words.Length;
    int i=0;
    while(i<length)
    {
        if(i==0)
        {
            initialLetter+= words[i];
        }
        else if (words[i]== ' ')
        {
            initialLetter+= words[i+1];
        }
    i++;

    }
     return initialLetter.ToUpper();
    }

}




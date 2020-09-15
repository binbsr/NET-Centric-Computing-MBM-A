
class Methods{

    //Function that calculates the sum of two numbers, returns true if sum>500, returns false otherwise

    public bool FindSum(int num1, int num2){
        int sum = num1 + num2;
        if(sum >500)
            return true;
        else
            return false;
    }


    /*Function that takes the number of wins, losses and draws of a point in football games and calculates the points
    a team has received using the given data
    win = 5 points
    draw = 2 points
    loss = 0 points*/

    public int FindPoints(int wins, int draws, int losses){
        int points = (wins* 5 + draws* 2);
        return points;
    }


    /* Function that takes two strings separated by space and returns the first characters of each string in concatenated form*/

    public string GetInitials(string myString){
        string initials = "";
        initials += myString[0];
        int lengthOfString = myString.Length;
        for(int i=1; i<lengthOfString; i++){
            if(myString[i] == ' ')
                initials+= myString[i + 1];
        }

        return initials.ToUpper();
    }
}


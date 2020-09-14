using System;
public class Concate{
    internal String GetInitials(string words){
        String initialLetter = "";
        bool v = true;
        foreach(char c in words){
            if(c==' ')
            v=true;
            else if(c!=' '&& v==true){
                initialLetter +=c;
                v=false;
            }
        }
        return initialLetter;
}
}
class Operation{

//sum of two number
   internal bool SumOfTwoNum(int a, int b)
          {
         int sum=a+b;
         if(sum>500)
         {
             return true;
         }
         else
         {
         return false;

         }

          } 
 //football score question  
          internal  int CalculatePoint(int wins, int draws, int losses)
          {

              return(wins*5 + draws*2 +0);//As looser always get no point.

          }

          //cancatination od String 

         internal string GetInitials(string word) 
          {
          string start=" ";
        
        bool a=true;
        for(int i=0; i<word.Length; i++)
        {

       if(word[i]==' ')
       {
           a=true;
       }
       else if(word[i]!=' '&& a==true)
       
       {
           start+=(word[i]);
           a=false;

       }

        }
        return start;

              }
          }



         

         
        
    
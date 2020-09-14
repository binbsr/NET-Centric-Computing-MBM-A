using System;
class SelectionStatement
{
static void Main1()
  {
     SelectionStatement selectionStatement=new SelectionStatement();
     selectionStatement.LearnIfElse();
  } 
  void LearnIfElse()
   {
      Console.Write("Enter a number");
      string input= Console.ReadLine();
      byte x= byte.Parse(input);
 
       if (x==34)
       {
           Console.WriteLine("u pressed 34");
       }
       else if (x==20)
       {Console.WriteLine("You pressed 20");
       }
 
       else
       {
           Console.WriteLine("You pressed others");
 
       }
   }  
   void LearnSwitch()
   {
       char option = 'y';
       switch(option)
       {
           case 'n':
           Console.WriteLine("you chose NO");
           break;
 
           case 'y':
           Console.WriteLine("you chose Yes");
 
           break;
 
           case 'x':
           Console.WriteLine("you chose NO");
           break;
 
           case 'z':
           Console.WriteLine("you chose YEs");
           break;
 
           default:
           break;
 
       }
   }
}
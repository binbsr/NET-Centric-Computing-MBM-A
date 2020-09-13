using System;

class AccessModifier
{
    internal void DoSomething()
    {

    }

   public void DoAnotherThing()
    {
        DoSomething();
    }
}
class ModifierDemo
{
    void DoSomething()
    {
       Person person= new Person();
       person.name ="Kushal";
       person.Age= 34;
    }
}
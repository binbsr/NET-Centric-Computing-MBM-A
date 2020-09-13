using System;

//by default class were internal modifier
class AccessModifer {

    void DoSomething(){

    }

    //sincce it is internal it can be access by another class
    internal void DoAnotherThing(){

    }
}

class ModifierDemo {

    void Main4(){
        AccessModifer obj1 = new AccessModifer();
        obj1.DoAnotherThing();
        //can't be access as it is by default private
        //obj1.DoSomething() 

        Person newPerson = new Person();
        newPerson.name = "Rajesh";
    }

    void DoAnotherThing(){
        
    }
}
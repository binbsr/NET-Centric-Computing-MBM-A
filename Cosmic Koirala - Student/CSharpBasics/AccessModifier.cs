public class AccessModifier
{
    internal void DoSomething()
    {

    }

    void DOAnotherThing()
    {
        DoSomething();
    }
}

class ModifierDemo
{
    void DOSomething()
    {
        Person person = new Person();
        person.Age=34;
    }

}
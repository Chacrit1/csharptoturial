//A property is like a combination of a variable and a method, and it has two methods:
//a get and a set method:

class Person
{
    private string name; // field

    public string Name   // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }
}
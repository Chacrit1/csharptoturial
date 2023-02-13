//A method is a block of code which only runs when it is called.
//You can pass data, known as parameters, into a method.

void myMethod(){
    Console.WriteLine("Hello World!");
}

//To call(execute) a method, write the method's name followed by two parentheses () and a semicolon;
//In the following example, MyMethod() is used to print a text (the action), when it is called:

myMethod();

//A method can be called multiple times:
myMethod();
myMethod();
myMethod();

//They are specified after the method name, inside the parentheses.
//You can add as many parameters as you want, just separate them with a comma.

void myMethodWithOneParameter(string name) 
{
    Console.WriteLine(name);
}

myMethodWithOneParameter("John");

//You can also use a default parameter value, by using the equals sign (=).

void myMethodWithDefaultParameter(string name = "John")
{
    Console.WriteLine(name);
}

myMethodWithDefaultParameter();

//If you want the method to return a value, you can use a primitive data type
//(such as int or double) instead of void, and use the return keyword inside the method:

int plusNumber(int x, int y)
{
    return x + y;
}

Console.WriteLine(plusNumber(5, 10));

//It is also possible to send arguments with the key: value syntax.

void myMethodWithNamedArguments(string child1, string child2, string child3) 
{
    Console.WriteLine("The youngest child is: " + child3);
}

myMethodWithNamedArguments(child3: "John", child1: "Liam", child2: "Liam");
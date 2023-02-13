/*A constructor is a special method that is used to initialize objects. The advantage of a constructor, 
is that it is called when an object of a class is created.It can be used to set initial values 
for fields: */


// Create a Car class
class Car
{
    public string model;  // Create a field

    // Create a class constructor for the Car class
    public Car()
    {
        model = "Mustang"; // Set the initial value for model
    }

    static void Main(string[] args)
    {
        Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
        Console.WriteLine(Ford.model);  // Print the value of model
    }
}
// Outputs "Mustang"


//Constructors can also take parameters, which is used to initialize fields.
class Car2
{
    public string model;

    // Create a class constructor with a parameter
    public Car2(string modelName)
    {
        model = modelName;
    }

    static void Main(string[] args)
    {
        Car2 Ford = new Car2("Mustang");
        Console.WriteLine(Ford.model);
    }
}

// Outputs "Mustang"
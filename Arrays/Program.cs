//To declare an array, define the variable type with square brackets:

string[] cars;

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

int[] myNum = { 10, 20, 30, 40 };

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
Console.WriteLine(cars[0]);
// Outputs Volvo

//To change the value of a specific element, refer to the index number:
cars[0] = "Opel";


string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
cars[0] = "Opel";
Console.WriteLine(cars[0]);
// Now outputs Opel instead of Volvo


//To find out how many elements an array has, use the Length property:
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
Console.WriteLine(cars.Length);
// Outputs 4
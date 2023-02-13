/*Variables are containers for storing data values.

In C#, there are different types of variables (defined with different keywords), for example:

int - stores integers (whole numbers), without decimals, such as 123 or -123

double - stores floating point numbers, with decimals, such as 19.99 or -19.99

char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes

string - stores text, such as "Hello World". String values are surrounded by double quotes

bool - stores values with two states: true or false*/

//To create a variable, you must specify the type and assign it a value:

//type variableName = value;

//Create a variable called name of type string and assign it the value "John":

string name = "John";

//Create a variable called myNum of type int and assign it the value 15:

int myNum1 = 15;

//You can also declare a variable without assigning the value, and assign the value later:

int myNum2;
myNum2 = 15;

//Note that if you assign a new value to an existing variable, it will overwrite the previous value:

int myNum3 = 15;
myNum3 = 20; // myNum is now 20

//A demonstration of how to declare variables of other types:
int myNum4 = 5;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";

/*If you don't want others (or yourself) to overwrite existing values, you can add the const keyword in front of the variable type.
This will declare the variable as "constant", which means unchangeable and read-only:*/

const int myNum = 15;
//myNum = 20; // error

//To declare more than one variable of the same type, use a comma-separated list:
int x = 5, y = 6, z = 50;

//You can also assign the same value to multiple variables in one line:
int x, y, z;

/*
All C# variables must be identified with unique names.
These unique names are called identifiers.
Identifiers can be short names (like x and y) or more descriptive names (age, sum, totalVolume).
Note: It is recommended to use descriptive names in order to create understandable and maintainable code:*/

/*
The general rules for naming variables are:
Names can contain letters, digits and the underscore character (_)
Names must begin with a letter
Names should start with a lowercase letter and it cannot contain whitespace
Names are case sensitive ("myVar" and "myvar" are different variables)
Reserved words (like C# keywords, such as int or double) cannot be used as names
 */

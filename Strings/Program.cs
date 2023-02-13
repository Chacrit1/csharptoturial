/*
Strings are used for storing text.
A string variable contains a collection of characters surrounded by double quotes:
 */

//Create a variable of type string and assign it a value:
string greeting = "Hello";

//A string variable can contain many words, if you want:
string greeting2 = "Nice to meet you!";

/*
 * A string in C# is actually an object, which contain properties and methods 
 * that can perform certain operations on strings. 
 * For example, the length of a string can be found with the Length property:
 */

string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + txt.Length);

/* String Concatenation The + operator can be used between strings to combine them. 
 * This is called concatenation:*/

string firstName = "John ";
string lastName = "Doe";
string name = firstName + lastName;
Console.WriteLine(name);

//You can also use the string.Concat() method to concatenate two strings:

string firstName = "John ";
string lastName = "Doe";
string name = string.Concat(firstName, lastName);
Console.WriteLine(name);

/*
Another option of string concatenation, is string interpolation, which substitutes values of variables 
into placeholders in a string. Note that you do not have to worry about spaces, like with concatenation:
*/

string firstName = "John";
string lastName = "Doe";
string name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name);

//Access Strings

/*
You can access the characters in a string by referring to its index number inside square brackets [].
This example prints the first character in myString:
 */

string myString = "Hello";
Console.WriteLine(myString[0]);

//You can also find the index position of a specific character in a string, by using the IndexOf() method:
string myString = "Hello";
Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"


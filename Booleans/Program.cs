/*
Very often, in programming, you will need a data type that can only have one of two values, like:
    YES / NO
    ON / OFF
    TRUE / FALSE
For this, C# has a bool data type, which can take the values true or false.
 */

//A boolean type is declared with the bool keyword and can only take the values true or false:

bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun);
Console.WriteLine(isFishTasty);

/*
Boolean Expression
A Boolean expression returns a boolean value: True or False, by comparing values/variables.
This is useful to build logic, and find answers.
For example, you can use a comparison operator, such as the greater than (>) operator to find out 
if an expression (or a variable) is true:
*/

int x = 10;
int y = 9;
Console.WriteLine(x > y); // returns True, because 10 is higher than 9

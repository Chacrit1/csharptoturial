/*
    C# Conditions and If Statements
    C# supports the usual logical conditions from mathematics:
    Less than: a < b
    Less than or equal to: a <= b
    Greater than: a > b
    Greater than or equal to: a >= b
    Equal to a == b
    Not Equal to: a != b
    You can use these conditions to perform different actions for different decisions.

    C# has the following conditional statements:
    Use if to specify a block of code to be executed, if a specified condition is true
    Use else to specify a block of code to be executed, if the same condition is false
    Use else if to specify a new condition to test, if the first condition is false
    Use switch to specify many alternative blocks of code to be executed
 */


//Use the if statement to specify a block of C# code to be executed if a condition is True.

/*
 if (condition) 
 {
 // block of code to be executed if the condition is True
 }
*/

if (20 > 18)
{
    Console.WriteLine("20 is greater than 18");
}

int x = 20;
int y = 18;

if (x > y)
{
    Console.WriteLine("x is greater than y");
}

//Use the else statement to specify a block of code to be executed if the condition is False
/*
 if (condition)
{
  // block of code to be executed if the condition is True
} 
else 
{
  // block of code to be executed if the condition is False
}
 */

int time = 20;
if (time < 18)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}

//Use the else if statement to specify a new condition if the first condition is False.

/*
 if (condition1)
{
  // block of code to be executed if condition1 is True
} 
else if (condition2) 
{
  // block of code to be executed if the condition1 is false and condition2 is True
} 
else
{
  // block of code to be executed if the condition1 is false and condition2 is False
}
 */

int time = 22;
if (time < 10)
{
    Console.WriteLine("Good morning.");
}
else if (time < 20)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}

//Short Hand If...Else (Ternary Operator)
//variable = (condition) ? expressionTrue :  expressionFalse;

int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);
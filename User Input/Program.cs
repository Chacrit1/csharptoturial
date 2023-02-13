/*
You have already learned that Console.WriteLine() is used to output (print) values. 
Now we will use Console.ReadLine() to get user input.
In the following example, the user can input his or hers username,
which is stored in the variable userName. Then we print the value of userName:
*/

// Type your username and press enter
Console.WriteLine("Enter username:");

// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is: " + userName);
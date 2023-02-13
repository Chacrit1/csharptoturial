/*
for (statement 1; statement 2; statement 3) 
{
  // code block to be executed
} 
*/

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

//There is also a foreach loop, which is used exclusively to loop through elements in an array:

/*
 foreach (type variableName in arrayName) 
{
  // code block to be executed
}
 */

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string i in cars)
{
    Console.WriteLine(i);
}
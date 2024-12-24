// See https://aka.ms/new-console-template for more information

// Check type
string myVariable = "This fruit is an apple.";
Type dataType = myVariable.GetType();
Console.WriteLine(dataType);


// Assigning an integer to variable of type obj
object myObjVariable = 123;
if(myObjVariable.GetType() == typeof(int)){
    Console.WriteLine($"The variable {myObjVariable} is an integer.");
} else
{
    Console.WriteLine($"The variable {myObjVariable} is NOT an integer");
}

// Assigning a string to the same variable of type obj
myObjVariable = "123";
if(myObjVariable.GetType() == typeof(int)){
    Console.WriteLine($"The variable {myObjVariable} is an integer.");
} else
{
    Console.WriteLine($"The variable {myObjVariable} is NOT an integer");
}

// Parse string to integer
myVariable = "123";
int number = int.Parse(myVariable);
Console.WriteLine(number + 1);


// Try parse string to integer
if(int.TryParse(myVariable, out int parsed_number))
{
    Console.WriteLine($"Conversion successful: {parsed_number}");
} else
{
    Console.WriteLine($"Conversion Failed");
}
Console.WriteLine(parsed_number);
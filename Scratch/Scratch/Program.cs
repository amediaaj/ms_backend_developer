
// C# syntax for arrays
int[] numbers = {1, 2, 3, 4, 5};

// Create an array of four elements, and add values later
string[] cars_0 = new string[4];

// Create an array of four elements and add values right away 
string[] cars_1 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements without specifying the size 
string[] cars_2 = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements, omitting the new keyword, and without specifying the size
string[] car_3 = {"Volvo", "BMW", "Ford", "Mazda"};

//However, you should note that if you declare an array and initialize it later, you have to use the new keyword:
// Declare an array
string[] cars_4;

// Add values, using new
cars_4 = new string[] {"Volvo", "BMW", "Ford"};

// Add values without using new (this will cause an error)
// cars = {"Volvo", "BMW", "Ford"};

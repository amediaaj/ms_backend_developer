// Initialize a string
string text = "Hello World";
int vowelCount = 0;


// Loop through each character in the string
foreach (char c in text.ToLower())
{
    // Check if the character is a vowel
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
    {
        vowelCount++;
    }
}


// Output the number of vowels
Console.WriteLine("The number of vowels is: " + vowelCount);
class Program
{
    static void Main ()
    {
        int[] numbers = {1, 2, 3, 4, 5};
        Console.WriteLine("Sum of numbers: " + CalculateSum(numbers));
    }

    static int CalculateSum(int[] numbers)
    {
        int sum = 0;
        // This loop will throw an exception because it is trying to access an index that is out of bounds
        // for(int i = 0; i < numbers.Length; i++)
        // Fixed with CoPilot. Highlight loop, click yellow sparkle, /explain the error is in the for loop, /fix
        for(int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
}

/*
Step-by-Step Code Construction:
Initial Review of the Code: Start by reviewing the provided code, which contains issues related to loop inefficiencies, incomplete input validation, and incorrect handling of edge cases. Before making any changes, analyze the code manually to identify potential problem areas.

Using Copilot to Identify Logical Errors:

Activate Microsoft Copilot and load the code into your IDE.

Ask Copilot for suggestions on improving the code, such as pointing out inefficient loops, validation gaps, or redundant operations.

Use Copilot’s recommendations to pinpoint errors you may have missed, especially regarding how the loop processes each item in a list.

Example prompt: "Copilot, suggest improvements for this loop to handle all task scenarios."

Optimizing Loops with Copilot:

Once Copilot provides suggestions, focus on the loop structure.

Use Copilot to help you rewrite the loop, ensuring it properly handles all items in a list without unnecessary iterations.

Ensure that the loop now works efficiently, especially when dealing with empty lists or lists that are near the boundary of the program’s constraints.

Example prompt: "How can I optimize this loop for better performance?"

Improving Input Validation: Input validation in this code can be made more robust with Copilot’s assistance.

Use Copilot to identify weak points in the current validation logic, especially handling inputs that are non-numeric, out-of-range, or edge cases like empty strings.

Implement the improvements Copilot suggests and test how they handle various invalid input scenarios.

Example prompt: "Can you suggest how to strengthen this input validation block?"

Handling Edge Cases with Copilot’s Suggestions: Often, code can break when handling unusual inputs or unexpected user actions (e.g., trying to mark a non-existent task). Use Copilot to recommend how to better manage these edge cases.

Ask Copilot to help you handle cases such as no tasks being present, marking a task that doesn’t exist, or exiting the program unexpectedly.

Review and implement Copilot’s suggestions, ensuring that the program gracefully handles all edge cases.

Final Testing and Validation: After implementing Copilot’s suggestions, run multiple tests to ensure all edge cases and validation scenarios are handled correctly.

Test the program with valid and invalid inputs.

Ensure the loop runs efficiently for both small and large datasets.

Confirm that input validation prevents crashes or incorrect behavior.
*/
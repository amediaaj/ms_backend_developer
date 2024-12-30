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
        for(int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
}
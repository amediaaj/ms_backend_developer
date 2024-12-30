class Program
{
    static void Main ()
    {
        int[] numbers = {1, 2, 3, 4, 5};
        // Fixed with CoPilot:
        // Integer sum = 0;
        int sum = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("Sum of numbers: " + sum);
    }
}
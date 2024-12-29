class Program {
    static char CalculateGrade(int studentScore){
        return studentScore switch{
            >= 90 => 'A',
            >= 80 => 'B',
            >= 70 => 'C',
            >= 60 => 'D',
            _   => 'F'
        };
    }
    static void Main(string[] args)
    {
        Console.WriteLine(CalculateGrade(85));
    }
}
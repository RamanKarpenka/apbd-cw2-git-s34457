public static class Program
{
    static double CalculateAverage(int[] values)
    {
        double sum = 0;

        foreach (var v in values)
            sum += v;
        
        return sum / values.Length;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Application to math methods");
        Console.WriteLine("What is your name?: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hi " +  name);
    }
}
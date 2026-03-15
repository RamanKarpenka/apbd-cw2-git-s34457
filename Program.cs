public static class Program
{
    static double CalculateAverage(int[] values)
    {
        double sum = 0;

        foreach (var v in values)
            sum += v;
        
        return sum / values.Length;
    }
    
    static int CalculateMax(int[] values)
    {
        return values.Max();
    }
    
    static int CalculateMin(int[] values)
    {
        return values.Min();
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Application to math methods");
        Console.WriteLine("What is your name?: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hi " +  name);
        
        Console.WriteLine("Enter numbers separated by space");  
        string input = Console.ReadLine();
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
        double avg = CalculateAverage(numbers);
        Console.WriteLine("Average: " + avg);
        
        double max = CalculateMax(numbers);
        Console.WriteLine("Max: " + max);
        
        double min = CalculateMin(numbers);
        Console.WriteLine("Min: " + min);
        
        Console.WriteLine("Have a nice day!");
    }
}
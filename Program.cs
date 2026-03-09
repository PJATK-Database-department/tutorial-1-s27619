class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("Calculator");
        Console.WriteLine("Enter numbers separated by space:");

        string input = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Error: No numbers provided.");
            return;
        }
        
        string[] parts = input.Split(' ');
    }
}
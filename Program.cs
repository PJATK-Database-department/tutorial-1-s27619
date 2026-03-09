class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("Calculator");
        Console.WriteLine("Enter numbers separated by space:");

        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
    }
}
// See https://aka.ms/new-console-template for more information
internal class Program
{
    
        private static void Main(string[] args)
        {
        Console.WriteLine("Hello, What is your name?");
        string userName = Console.ReadLine();

        Console.WriteLine("What is your dream car?");
        string carName = Console.ReadLine();

        Console.WriteLine("What color is your dream car?");
        string carColor = Console.ReadLine();

        Console.WriteLine("Where is one place you always dreamed of visiting?");
        string dreamPlace = Console.ReadLine();


        Console.WriteLine($"There was once a person named {userName}");
        Console.WriteLine($"{userName} was very rich and owned a {carColor} {carName}.");
        Console.WriteLine($"{userName} would always drive his {carName} around {dreamPlace}");

        Console.WriteLine("Give me a number to add");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Give me a number to add to the first number");
        int num2 = int.Parse(Console.ReadLine());

        int sum = Sum(num1, num2);
        Console.WriteLine($"The sum is {sum}");
    }
   public static int Sum(int num1, int num2)
    {
     return num1 + num2;    
    }
   public static int Multiply(int x, int y )
    {
        return x * y;   
    }
}

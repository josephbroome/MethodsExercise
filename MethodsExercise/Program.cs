// See https://aka.ms/new-console-template for more information
internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, What is your name?");
        string userName = Console.ReadLine();

       
        Console.WriteLine("What is your favorite band?");
        string bandName = Console.ReadLine();

        Console.WriteLine(" What is your farvorite song?");
        string songName = Console.ReadLine();

        Console.WriteLine(" What is your favorite color");
        string colorName = Console.ReadLine();

        Console.WriteLine($" There was once a person named {userName}. His favorite band was {bandName}");
        Console.WriteLine($" {userName} favorite song from {bandName} was {songName} and {userName}'s favorite color was {colorName}");

        Console.WriteLine("give me a number to add");
        int num1 = int .Parse(Console.ReadLine());

        Console.WriteLine("give me number to add to the first one");

        int num2 = int .Parse(Console.ReadLine());

        Console.WriteLine(Sum(num1, num2));

        Console.WriteLine("give me a number");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("give me a number to multpily with the first");
        int y = int.Parse(Console.ReadLine());  

        Console.WriteLine($"the product is {(Multiply(x, y))}");

       Console.WriteLine( Sum1(1, 2, 3, 4));

        Console.WriteLine( Sum2(1, 10, 11, 12));


   
    }
    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }
    public static int Multiply(int x, int y)
    {
        return x * y;
    }
    public static int Sum1(params int[] list)
    {
        int sum1 = 0;
        for (int i = 0; i < list.Length; i++)
        {
            sum1 = sum1 + list[i];
        }
        return sum1;
    }
    public static int Sum2(params int[] list)
    {
        int sum2 = 0;
        for (int i = 0; i < list.Length; i++)
        {
            sum2 = sum2 + list[i];
        }
        return sum2;
    }
    public static int Sum3(params int[] list)
    {
        int sum3 = 0;
        for (int i = 0; i < list.Length; i++)
        {
            sum3 = sum3 + list[i];
        }
        return sum3;
    }

    public static int Addition(int num1, int num2)
    {
        return num1 + num2;
    }

    public static void AgeChecker()
    {
        bool oldEnough;
        
        do
        {
            Console.WriteLine("Hello, how old are you?");

            int userAge = int.Parse(Console.ReadLine());

            if (userAge < 21)

            {

                Console.WriteLine("Sorry you are not olde enough to drink");
                oldEnough = false;
            }

            else
            {
                Console.WriteLine("Welcome to our Brewery webstie");
                oldEnough = true;

            }





        } while (oldEnough == false);
    }

    public static void GoodEvening()
    {
        bool timeOfday;

        do
        {
            Console.WriteLine("Whit time of day is it?");

            int whatTime = int.Parse(Console.ReadLine());

            if (whatTime < 12)
            {
                Console.WriteLine("Good morning!");


                timeOfday = false;
            }
            
            else
            {
                Console.WriteLine("Good evening!");

                timeOfday = true;   
            }
        } while (timeOfday == false);   

    }
}

// See https://aka.ms/new-console-template for more information
internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, What is your name?");
        string userName = Console.ReadLine();

        //Console.WriteLine("What is your dream car?");
        //string carName = Console.ReadLine();

        //Console.WriteLine("What color is your dream car?");
        //string carColor = Console.ReadLine();

        //Console.WriteLine("Where is one place you always dreamed of visiting?");
        //string dreamPlace = Console.ReadLine();


        //Console.WriteLine($"There was once a person named {userName}");
        //Console.WriteLine($"{userName} was very rich and owned a {carColor} {carName}.");
        //Console.WriteLine($"{userName} would always drive his {carName} around {dreamPlace}");

        //Console.WriteLine("Give me a number to add");
        //int num1 = int.Parse(Console.ReadLine());

        //Console.WriteLine("Give me a number to add to the first number");
        //int num2 = int.Parse(Console.ReadLine());

        //int sum = Sum(num1, num2);
        //Console.WriteLine($" the sum is {sum}");

        //int sum1 = Sum1(2, 4);
        //Console.WriteLine($"The sum is {sum1}");
        //int sum2 = Sum2(2, 4, 6);
        //Console.WriteLine($"The sume is {sum2}");
        //int sum3 = Sum3(1, 1, 1, 1, 1);
        //Console.WriteLine($"The sum is {sum3}");

        //Console.WriteLine("Give me a number");
        //num1 = int.Parse(Console.ReadLine());

        //Console.WriteLine("Give me a number to multiply with the first one");
        //num2 = int.Parse(Console.ReadLine());

        //int product = Multiply(num1, num2);
        //Console.WriteLine($"The product is {product}");

        //int answer1 = Addition(500, 200);
        //Console.WriteLine(answer1);
        //int answer2 = Addition(1000, 200000);

        //AgeChecker();

        //GoodEvening();

        Console.WriteLine("What is your favorite band?");
        string bandName = Console.ReadLine();

        Console.WriteLine(" What is your farvorite song?");
        string songName = Console.ReadLine();

        Console.WriteLine(" What is your favorite color");
        string colorName = Console.ReadLine();

        Console.WriteLine($" There was once a person named {userName}. His favorite band was {bandName}");
        Console.WriteLine($" {userName} favorite song from {bandName} was {songName} and {userName}'s favorite color was {colorName}");

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

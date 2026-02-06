namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Prime number

        // Collects value from user
        Console.WriteLine("Input an integer:");
        int userInt = Convert.ToInt32(Console.ReadLine());
        
        // Initializes isPrime variable
        bool isPrime = true;

        // If a number is less than or equal to 1, it is not prime
        if (userInt <= 1)
        {
            Console.WriteLine("N is not prime");
            return;
        }
        else
        {
            // If a number is greater than 1, checks for factors
            for (int i = 2; i <= userInt -1; i++)
            {
                if (userInt % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine("N is prime");
        }
        else
        {
            Console.WriteLine("N is not prime");
        }

        // Part 2: Printing a pattern

        // Collects value from user
        Console.WriteLine("Assign an int value to N:");
        int n = Convert.ToInt32(Console.ReadLine());

        // Prints the pattern based on N
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }

        // Part 3: Triangle pattern

        // Collects values from user
        Console.WriteLine("Assign an int value to N:");
        int N = Convert.ToInt32(Console.ReadLine());

        // Prints the triangle pattern based on N
        for (int i = 1; i <= N; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // Part 4: Prints a numeric triangle

        // Collects value from user
        Console.WriteLine("Assign an int value to N:");
        int Nnum = Convert.ToInt32(Console.ReadLine());

        // Prints the numeric triangle based on N
        for (int i = 1; i <= Nnum; i++)
        {
            //Prints Spaces
            for (int k = 1; k <= Nnum - i; k++)
            {
                Console.Write(" ");
            }
            //Prints Numbers
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}

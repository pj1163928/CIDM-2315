using System.ComponentModel;
using System.Transactions;

namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        //Q1 Returns Largest of 2 Integers

        //Collects Integer Values
        Console.WriteLine("First int: ");
        int num1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Second int: ");
        int num2 = int.Parse(Console.ReadLine()!);
        //Uses method to determine largest integer value
        int largest = getLargest(num1, num2);
        Console.WriteLine("The largest of the integers is: " + largest);

        //Q2 Largest of 4 Integers

        //Collects Integer Values
        Console.WriteLine("First int: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Second int: ");
        int b = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Third int: ");
        int c = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Fourth int: ");
        int d = int.Parse(Console.ReadLine()!);
        //Determines largest of first 2
        int max1 = getLargest(a, b);
        //Determines the largest of 3 and 4
        int max2 = getLargest(c, d);
        //Determines largest based on the max values from previous steps
        int max = getLargest(max1, max2);
        Console.WriteLine("The largest of the integers is: " + max);

        //Q3 Account Creation
        Console.WriteLine("To create your account, please input the information as neccesary");
        //Collects user values
        Console.WriteLine("Please input your username: ");
        string username = Console.ReadLine()!.ToUpper().Trim();
        Console.WriteLine("Please input your password: ");
        string password = Console.ReadLine()!.Trim();
        Console.WriteLine("Please confirm your password: ");
        string password1 = Console.ReadLine()!.Trim();
        Console.WriteLine("Please input your birthyear: ");
        int birth_year = int.Parse(Console.ReadLine()!);

        //Uses modules to determine age verification
        bool isOldEnough = checkAge(birth_year);
        //Creates or Refuses account creation based on criteria from modules
        createAccount(password, password1, isOldEnough);

        bool age = checkAge(birth_year);
    }
    static int getLargest(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static bool checkAge(int birth_year)
    {
        //Local Variable:
        //Subtracts current and given year
        int currentYear = DateTime.Now.Year;

        //Evaluates if birth year is 18 and above (T/F)
        if (currentYear - birth_year <= 17)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    static void createAccount(string password, string password1, bool isOldEnough)
    {
        //If passwords match
        if (password == password1)
        {
            //AND user age is = True
            if (isOldEnough == true)
            {
                Console.WriteLine("Account Created");
                return;
            }
            //Refuses account creation
            else
            {
                Console.WriteLine("Account can not be created. RE: AGE < 18");
                return;
            }

        }
        //If passwords do not match
        else
        {
            Console.WriteLine("Passwords do not match.");
            return;
        }
    }
}

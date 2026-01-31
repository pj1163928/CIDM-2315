namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
    // Code for Q1
       Console.WriteLine("Please input a letter grade: ");
       //Converts the user input to upperacase
       string user_input = Console.ReadLine().ToUpper();

       //Checks user input to the values and return the correct GPA
       if (user_input == "A")
       {
        Console.WriteLine("GPA points: 4.0");
       }
       else if (user_input == "B")
       {
        Console.WriteLine("GPA points: 3.0");
       }
       else if (user_input == "C")
       {
        Console.WriteLine("GPA points: 2.0");
       }
       else if (user_input == "D")
       {
        Console.WriteLine("GPA points: 1.0");
       }
       else if (user_input == "F")
       {
        Console.WriteLine("GPA points: 0.0");
       }
       else
       {
        Console.WriteLine("Wrong Letter Grade!");
       }

    // Code for Q2
        //Collects three numbers from user
        Console.WriteLine("Please input the first num: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please input the second num: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please input the third num: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        //If number 1 is less than or equal to number 2 and number 3
        if (num1 <= num2 && num1 <= num3)
        {
            Console.WriteLine("The smallest value is: " + num1);
        }
        //If number 2 is less than or equal to number 1 and number 3
        else if (num2 <= num1 && num2 <= num3)
        {
            Console.WriteLine("The smallest value is: " + num2);
        }
        //The smallest value
        else
        {
            Console.WriteLine("The smallest value is: " + num3);
        }

    // Code for Q3
        //Collects year from user
        Console.WriteLine("Please input a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        //If the remainder of year divided by 4 is 0 and the remainder of year divided by 100 is not 0
        //Or if the remainder of year divided by 400 is 0
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine(year + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }
}

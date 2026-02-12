using System;

namespace Homework;

class Program
{
    //Calling methods
    static void Main()
    {
        //Collecting user input and calling getLargest method
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());
        int largest = getLargest(num1, num2);
        Console.WriteLine("The largest number is: " + largest);

        //Collecting user input and calling drawTriangle method
        Console.WriteLine("Enter the height of the triangle:");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the shape of the triangle Left or Right:");
        string shape = Console.ReadLine();
        drawTriangle(height, shape);
    }
    //Method to find the largest of two numbers
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
    //Method to draw a triangle based on user input
    static void drawTriangle(int height, string shape)
    {
        //If left is chosen
        if (shape.ToLower() == "left")
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        //If right is chosen
        else if (shape.ToLower() == "right")
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid shape");
        }
    }
}

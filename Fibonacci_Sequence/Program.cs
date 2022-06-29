using System;
public class Program
{
    public static void Main(string[] args)
    {
        // Enter how many Fibonacci numbers to print
        int fibonacciLength;

        // Variables f1 and f2 are two Fibonacci numbers which are used to find the next Fibonacci number
        int f1 = 0, f2 = 1, f3;

        // Prompt message on the console about Fibonacci Number
        Console.Write("Enter amount of Fibonacci numbers you'd like: ");

        // Reads the next line of characters from the standard input stream and store it in a variable
        fibonacciLength = int.Parse(Console.ReadLine());

        // Printing 0 and 1
        Console.Write(f1 + " " + f2 + " ");

        // Loop starts from 2 because 0 and 1 are already printed
        for (int i = 2; i < fibonacciLength; i++)
        {
            // Fibonacci logic is : The current number is the sum of the 2 preceding numbers
            f3 = f1 + f2;

            // Print the newly created Fibonacci number
            Console.Write(f3 + " ");

            // Now set the latest 2 preceding numbers to find the next Fibonacci Number
            f1 = f2;
            f2 = f3;
        }
        Console.WriteLine("");
    }
}
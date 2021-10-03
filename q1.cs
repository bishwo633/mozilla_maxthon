using System;

namespace test2
{
public class Q1
{
    public static void q1()
    {
        // Get age from user
        Console.WriteLine("Enter your age:");
        string age = Console.ReadLine();

        // Prepare string for output
        // string output = "You are " + age + " years old";
        string output = $"Your are {age} years old";

        // Show the output to user 
        Console.WriteLine(output);
    }
}
}
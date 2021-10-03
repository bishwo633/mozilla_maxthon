using System;

namespace test2
{
public class Q2
{
    public static void q2()
    {
        // Get 3 inputs from user
        Console.WriteLine("Enter three integers:");
        string int1 = Console.ReadLine();
        string int2 = Console.ReadLine();
        string int3 = Console.ReadLine();

        // Covert string to int, then compare and get the max value
        int i1 = int.Parse(int1); //int i1 = Convert.ToInt32(int1);
        int i2 = int.Parse(int2);
        int i3 = int.Parse(int3);
        
        int max = 0;
        if (i1 > i2)
        {
            if (i1 > i3)
            {
                max = i1;
            }
            else
            {
                max = i3;
            }
        }
        else
        {
            if (i2 > i3)
            {
                max = i2;
            }
            else
            {
                max = i3;
            }
        }

        //inline format: (condition)?(true statement):(false statement);

        // if(condition)
        // {
        //     // true statement
        // }
        // else
        // {
        //     // false statement
        // }

        int max2 = (i1 > i2) ? ( (i1 > i3) ? i1 : i3 ) : ( (i2 > i3) ? i2 : i3 );

        // string output = "You are " + age + " years old";
        string output = $"The max value is {max2}";

        // Show the output to user 
        Console.WriteLine(output);
    }
}
}
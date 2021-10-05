using System;
using System.Linq;

namespace test2
{
    public class LoopTest
    {
        private static int[] myNumbers = {1,2,3,4,5,6,7,8,9,10};
        private static string[] daysOfWeek = {"Sun","Mon","Tue","Wed","Thu","Fri","Sat"};

        public static void WhileTest()
        {
            // maintain counter to stop the loop
            int i = 0;
            int sum = 0;

            while (i < myNumbers.Length) // Length / Count()    // (0 1 2 9 < 10 = true )
                                                                // (10 < 10 = false)
            {
                // statement
                // Console.WriteLine(myNumbers[i]);
                sum += myNumbers[i];
                // sum = 0 + 1 = 1
                // sum = 1 + 1 = 2
                // sum = 2 + 1 = 3
                // ...
                // sum = 45 + 10 = 55 

                // increment the counter
                i++; // 1 2 .... 9 10
            }

            // string numbersString = String.Join(",", myNumbers); //.Select(x => x.ToString()));

            // conert integer array to string array using lambda expression (item => item...)
            string[] myNumbersStrArray = myNumbers.Select(item => item.ToString());

            // join the array items
            string numbersString2 = String.Join(",", myNumbersStrArray);

            Console.WriteLine($"Sum of {numbersString2} is {sum}");

        }
    }
}
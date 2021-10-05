using System;
using System.Linq;
using System.Collections.Generic;

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
            string[] myNumbersStrArray = myNumbers.Select(item => item.ToString()).ToArray();

            // join the array items
            string numbersString2 = String.Join(",", myNumbersStrArray);

            Console.WriteLine($"Sum of {numbersString2} is {sum}");

        }

        public static void ForLoopTest()
        {
            

            // Other examples of list

            // Q1 variableName = new Q1();
            // Dog d1 = new Dog();

            // List<T> --> where T is a generic type (object)

            // List<int> intList = new List<int>();
            // List<float> floatList = new List<float>();
            // List<Q1> q1List = new List<Q1>();
            // List<Q2> q2List = new List<Q1>();

            /*
            List<string> months = new List<string>();

            months.Add("Jan");
            months.Add("Feb");
            months.Add("Mar");
            months.Add("Apr");
            months.Add("May");
            months.Add("Jun");
            months.Add("Jul");
            months.Add("Aug");
            months.Add("Sep");
            months.Add("Oct");
            months.Add("Nov");
            months.Add("Dec");
            months.Remove("Dec");
            */

            List<string> months = new List<string>{"Jan", "Feb", "Mar", "Apr", "..", "Dec"};
            
            Console.WriteLine("Using for loop");
            for(int i=0; i<months.Count(); i++)
            {
                var month = months[i];
                Console.WriteLine(month);
            }

            Console.WriteLine("Using foreach loop");
            foreach(var month in months)
            {
                Console.WriteLine(month);
            }

        }
    }
}
using System;

namespace Tutorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x = 4; 
            double y = 5;

            Console.WriteLine("GetSum(x, y) = {0}", GetSum(x, y));

            int solution;
            DoubleIt(2, out solution);
            Console.WriteLine("solution = {0}", solution);

            int num1 = 10;
            int num2 = 20;

            Console.WriteLine("Before swap: num1 = {0}, num2 = {1}", num1, num2);
            Swap(ref num1, ref num2);
            Console.WriteLine("After swap: num1 = {0}, num2 = {1}", num1, num2);

            // Create an array as values
            double[] values = { 1, 2, 3, 4, 5 };
            Console.WriteLine("GetSumMore(values) = {0}", GetSumMore(values));

            // Call PrintInfo with parameters
            PrintInfo(name: "Anik", zipCode: 12345, age: 25);

            // Call GetSum with parameters 5.0 and 4.5
            Console.WriteLine("GetSum(5.0, 4.5) = {0}", GetSum(5.0, 4.5));

            // Call GetSum with parameters "5" and "4"
            Console.WriteLine("GetSum(5, 4) = {0}", GetSum("5", "4"));

            // Call GetDayName with parameter Days.Monday
            GetDayName(Days.Monday);

        }

        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x; 
            x = y; 
            y = temp;

            return x + y;
        }

        // Override GetSum which takes input of 2 strings and convert them to double using Convert.ToDouble() before adding them up and returns the sum
        static double GetSum(string x = "1", string y = "1")
        {
            return Convert.ToDouble(x) + Convert.ToDouble(y);
        }

        // Double the value by value and return it by out
        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }
        
        // Swap value by reference
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y; 
            y = temp;
        }
        
        // Take input of array of params of double and return sum and name the function as GetSumMore and use foreach function in it 
        static double GetSumMore(params double[] values)
        {
            double sum = 0;
            foreach (double value in values)
            {
                sum += value;
            }
            return sum;
        }

        // Create a function PrintInfo which takes inputs of name as string, zipCode as int and age as int and displays them 
        static void PrintInfo(string name, int zipCode, int age)
        {
            // Display all the inputs
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Zip Code: {0}", zipCode);
            Console.WriteLine("Age: {0}", age);
        }

        // enum data type
        enum Days
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        // Create a function GetDayName which takes input of enum type and returns the name of the day
        static void GetDayName(Days day)
        {
            Console.WriteLine("Day[{0}]: {1}", (int)day, day);
        }

    }
}

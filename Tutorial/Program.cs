using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;


namespace Tutorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Write a string to the console followed
            // be a newline
            // Write() doesn't include a newline
            // The Console class provides functions for input
            // output and error streams for console applications

            Console.WriteLine("Hello World!");

            // for loops allow you to cycle through information
            // We will get command line arguments passed and print
            // them

            // Create an array of strings named args
            // args is an array of strings
            string[] argsArray = { "1", "2", "3" };

            for (int j = 0; j < argsArray.Length; j++)
            {
                Console.WriteLine(argsArray[j]);
            }

            Array array = new int[] { 1, 2, 3, 4, 5 };

            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }

            var name = "Anik";
            Console.WriteLine("name is a {0}", name.GetTypeCode());

            // Math operation
            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5 - 3 = " + (5 - 3));
            Console.WriteLine("5 * 3 = " + (5 * 3));
            Console.WriteLine("5 / 3 = " + (5 / 3));
            Console.WriteLine("5.2 % 3 = " + (5.2 % 3));

            int i = 0;

            Console.WriteLine("i++ = " + (i++));
            Console.WriteLine("++i = " + (++i));
            Console.WriteLine("i-- = " + (i--));
            Console.WriteLine("--i = " + (--i));

            Console.WriteLine("i += 3 " + (i += 3));
            Console.WriteLine("i -= 2 " + (i -= 2));
            Console.WriteLine("i *= 2 " + (i *= 2));
            Console.WriteLine("i /= 2 " + (i /= 2));
            Console.WriteLine("i %= 2 " + (i %= 2));

            // Type acsting
            int intVar = 5;
            long longVar = intVar;
            intVar = (int)longVar;
            // Print the result
            Console.WriteLine($"intVar: {intVar}, longVar: {longVar}");

            bool boolVar = true;
            char charVar = 'c';
            int maxInt = int.MaxValue;
            long maxLong = long.MaxValue;
            decimal maxDecimal = decimal.MaxValue;
            float maxFloat = float.MaxValue;
            double maxDouble = double.MaxValue;

            // byte : 8-bit unsigned int 0 to 255
            // char : 16-bit unicode character
            // sbyte : 8-bit signed int 128 to 127
            // short : 16-bit signed int -32,768 to 32,767
            // uint : 32-bit unsigned int 0 to 4,294,967,295
            // ulong : 64-bit unsigned int 0 to 18,446,744,073,709,551,615
            // ushort : 16-bit unsigned int 0 to 65,535

            Console.WriteLine($"boolVar: {boolVar}, charVar: {charVar}, maxInt: {maxInt}, maxLong: {maxLong}, maxDecimal: {maxDecimal}, maxFloat: {maxFloat}, maxDouble: {maxDouble}");

            // Convert data type
            bool a = bool.Parse("True");
            Console.WriteLine("a {1} is a {0}", a.GetTypeCode(), a);

            int b = int.Parse("5");
            Console.WriteLine("b {1} is a {0}", b.GetTypeCode(), b);

            double c = double.Parse("5.2");
            Console.WriteLine("c {1} is a {0}", c.GetTypeCode(), c);

            DateTime d = new DateTime(2020, 1, 1);
            Console.WriteLine("d {1} is a {0}", d.GetTypeCode(), d);
            Console.WriteLine("Day of the week: " + d.DayOfWeek);
            Console.WriteLine("Day of the year: " + d.DayOfYear);
            Console.WriteLine("Month: " + d.Month);
            Console.WriteLine("Year: " + d.Year);

            // Add 4 days with d
            d = d.AddDays(4);
            Console.WriteLine("Day of the week: " + d.DayOfWeek);
            Console.WriteLine("Day of the year: " + d.DayOfYear);
            Console.WriteLine("Month: " + d.Month);
            Console.WriteLine("Year: " + d.Year);

            // Add 4 months with d
            d = d.AddMonths(4);
            Console.WriteLine("Day of the week: " + d.DayOfWeek);
            Console.WriteLine("Day of the year: " + d.DayOfYear);
            Console.WriteLine("Month: " + d.Month);
            Console.WriteLine("Year: " + d.Year);

            // Add 4 years with d
            d = d.AddYears(4);
            Console.WriteLine("Day of the week: " + d.DayOfWeek);
            Console.WriteLine("Day of the year: " + d.DayOfYear);
            Console.WriteLine("Month: " + d.Month);
            Console.WriteLine("Year: " + d.Year);

            // Timespan
            TimeSpan dinnerTime = new TimeSpan(18, 30, 0);
            dinnerTime = dinnerTime.Subtract(new TimeSpan(0, 15, 0));
            Console.WriteLine("Dinner time: " + dinnerTime.ToString());
            dinnerTime = dinnerTime.Add(new TimeSpan(0, 25, 0));
            Console.WriteLine("Dinner time: " + dinnerTime.ToString());

            // Define a BigInteger
            BigInteger bigInt = BigInteger.Parse("1234567890123456789012345678901234567890");
            Console.WriteLine("Big integer: " + bigInt.ToString());
            Console.WriteLine("Square of big integer: " + (bigInt * bigInt).ToString());
            Console.WriteLine("Power of big integer: " + (bigInt * bigInt * bigInt).ToString());

            // Currency
            decimal currency = 123.45m;
            Console.WriteLine("Currency: " + currency.ToString("C"));
            Console.WriteLine("Currency: {0:c}", currency);
            Console.WriteLine("Pad with zero: {0:d4}", 1);
            Console.WriteLine("3 Decimals: {0:f3}", 123.456);
            Console.WriteLine("6 Decimals: {0:f6}", 123.456);
            Console.WriteLine("Commas: {0:n4}", 1234567890);

            // String
            // Define a string as str saying This is a string
            string str = "This is a string";
            // Print all string functions
            Console.WriteLine("Length of string: " + str.Length);
            Console.WriteLine("Upper case: " + str.ToUpper());
            Console.WriteLine("Lower case: " + str.ToLower());
            Console.WriteLine("Contains string: " + str.Contains("string"));
            Console.WriteLine("Starts with string: " + str.StartsWith("This"));
            Console.WriteLine("Ends with string: " + str.EndsWith("string"));
            Console.WriteLine("Index of string: " + str.IndexOf("string"));
            Console.WriteLine("Last index of string: " + str.LastIndexOf("string"));
            Console.WriteLine("Replace string: " + str.Replace("string", "text"));
            Console.WriteLine("Remove string: " + str.Remove(5, 4));
            Console.WriteLine("Substring: " + str.Substring(5, 4));
            Console.WriteLine("Trim: " + str.Trim());
            Console.WriteLine("Trim start: " + str.TrimStart());
            Console.WriteLine("Trim end: " + str.TrimEnd());
            Console.WriteLine("Split: " + str.Split(' '));
            Console.WriteLine("Split: " + str.Split(' ', StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine("Split: " + str.Split(' ', StringSplitOptions.TrimEntries));
            Console.WriteLine("Split: " + str.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine("Split: " + str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine("Split: " + str.Split(new char[] { ' ' }, StringSplitOptions.TrimEntries));
            Console.WriteLine("Split: " + str.Split(new char[] { ' ' }, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine("Split: " + str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine("String to char array: " + str.ToCharArray());
            Console.WriteLine("String Compare: " + string.Compare(str, "This is a string"), StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("String Compare: " + string.Compare(str, "This is a text"), StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("String Compare: " + string.Compare(str, "This is a substring", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("A = a: {0}", String.Equals("A", "a", StringComparison.Ordinal));
            Console.WriteLine("Pad Left: {0}", str.PadLeft(20, '.'));
            Console.WriteLine("Pad Right: {0}", str.PadRight(20, '.'));

            string anotherStr = String.Format("This is {0}", "another string");
            Console.WriteLine("Another string: " + anotherStr);
            Console.WriteLine(@"Exactly what I typed: '\ ");
        }

        private static void Test()
        {
            string name = "";
            Console.Write("Enter your name: ");
            // Convert the input to string
            name = Console.ReadLine() ?? "";
            if (name != null)
            {
                Console.WriteLine($"Hello, {name}!");
            }
        }
    }
}

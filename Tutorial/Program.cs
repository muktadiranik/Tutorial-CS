using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace Tutorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{j}, ");
            }

            Array array = new int[] {1, 2, 3, 4, 5};

            foreach (var item in array) {
                Console.Write($"{item}, ");
            }

            bool boolVar = true;
            char charVar = 'c';
            int maxInt = int.MaxValue;
            long maxLong = long.MaxValue;
            decimal maxDecimal = decimal.MaxValue;
            float maxFloat = float.MaxValue;
            double maxDouble = double.MaxValue;

            Console.WriteLine();
            Console.WriteLine($"boolVar: {boolVar}, charVar: {charVar}, maxInt: {maxInt}, maxLong: {maxLong}, maxDecimal: {maxDecimal}, maxFloat: {maxFloat}, maxDouble: {maxDouble}");
        
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
            
            Test();

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

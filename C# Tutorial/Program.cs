using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;


namespace C__Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("args[{0}] = {1}", i, args[i]);
            }

            int[] intArray = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("array[{0}] = {1}", i, intArray[i]);
            }

            string[] stringArray = new string[5] {"Apple", "Orange", "Banana", "Pear", "Grape"};

            for ( int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine("array[{0}] = {1}", i, stringArray[i]);
            }

            string[] myArgs = Environment.GetCommandLineArgs();

            Console.WriteLine("args = {0}", string.Join(" ", myArgs));

            for (int i = 0; i < myArgs.Length; i++)
            {
                Console.WriteLine("args[{0}] = {1}", i, myArgs[i]);
            }

            Console.WriteLine("addInt({0}, {1}): {2}", 5, 6, addInt(5, 6));
            Console.WriteLine("addString({0}, {1}): {2}", "Hello ", "World!", addString("Hello ", "World!"));


            // datatypes
            int myInt = 5;
            double myDouble = 5.5;
            long myLong = 5L;
            bool myBool = true;
            char myChar = 'a';
            string myString = "Hello World";

            Console.WriteLine("myInt = {0}", myInt);
            Console.WriteLine("myDouble = {0}", myDouble);
            Console.WriteLine("myLong = {0}", myLong);
            Console.WriteLine("myBool = {0}", myBool);
            Console.WriteLine("myChar = {0}", myChar);
            Console.WriteLine("myString = {0}", myString);

            
            // max and min values
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            float maxFloat = float.MaxValue;
            float minFloat = float.MinValue;
            decimal maxDecimal = decimal.MaxValue;
            decimal minDecimal = decimal.MinValue;
            
            Console.WriteLine("maxInt = {0}", maxInt);
            Console.WriteLine("minInt = {0}", minInt);
            Console.WriteLine("maxDouble = {0}", maxDouble);
            Console.WriteLine("minDouble = {0}", minDouble);
            Console.WriteLine("maxLong = {0}", maxLong);
            Console.WriteLine("minLong = {0}", minLong);
            Console.WriteLine("maxFloat = {0}", maxFloat);
            Console.WriteLine("minFloat = {0}", minFloat);
            Console.WriteLine("maxDecimal = {0}", maxDecimal);
            Console.WriteLine("minDecimal = {0}", minDecimal);

        }

        private static int addInt(int x, int y)
        {
            return x + y;
        }

        private static string addString(string x, string y)
        {
            return x + y;
        }
    }
}
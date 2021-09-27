using System;
using System.Collections.Generic;

namespace Variables_Exercise_01
{
    class Program
    {
        public struct PointA // A Value Type Container with a parameterized constructor
        {
            private double X;
            private double Y;

            public PointA(double x, double y) 
            {
                X = x;
                Y = y;
            }
        }
        public struct PointB // A Value Type Container with default constructor
        {
            public double X { get; set; }
            public double Y { get; set; }
        } 

        public enum MyEnum { Sun, Mon, Tue, Wed, Thu, Fri, Sat }; // A Value Type Collection

        static void Main(string[] args)
        {
            var myList = new List<object>();

            // - Complete all of the TODO's for this exercise
            // - Once finished save, commit, and then push to GitHub!

            #region List of C# Value Types https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
            //  DATATYPES         |       Size         |                           VALUES                          |
            sbyte _sbyte;               // 8 bit	                      -128 to 127
            byte _byte;                 // 8 bit	                         0 to 255
            short _short;               // 16 bit	                   -32,768 to 32,767
            ushort _ushort;             // 16 bit	                         0 to 65,535
            int _int;                   // 32 bit	            -2,147,483,648 to 2,147,483,647
            uint _uint;                 // 32 bit	                         0 to 4,294,967,295
            long _long;                 // 64 bit	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong _ulong;               // 64 bit	                         0 to 18,446,744,073,709,551,615

            float _float;               // 32 bit	               -1.5 x 1045 to 3.4 x 1038
            double _double;             // 64 bit	                -5 x 10324 to 1.7 x 10308
            decimal _decimal;           // 128 bit	                     -1028 to 7.9 x 1028

            char _char;                 // 16 bit	                         0 to 65535
            bool _bool;                 // ~1 bit	                      True or false
            #endregion

            // TODO: Declare 5 constansts
            const int num1 = 1;
            const int num2 = 2;
            const string name = "Seth";
            const string name2 = "Breagan";
            const bool isAlive = true;

            Console.WriteLine($"Hey, my name is {name}. My wife's name is {name2}.\n{num1} + {num2} = {num1 + num2}.\nIt would be {isAlive} that I am alive today.\n\n");

            // TODO: Declare 2 variables of each type from the list above (1 pair for each) 
            // Make sure to use C# naming convention best practices (camelCase, PascalCase, etc...)




            // TODO: Initialize 1 of the variables with that datatypes minimum value
            // TODO: Initialize the other variable with that datatypes maximum value
            // TODO: Write out each of the variables to the Console 
            sbyte min = sbyte.MinValue;
            sbyte max = sbyte.MaxValue;
            Console.WriteLine($"Sbyte min: {min} || Sbyte max: {max}\n\n");



            // **BONUS**
            // TODO: Create your own enum and initialize it with constants of your choosing
            // TODO: Declare it and then iterate through it writing out to the console            
            // TODO: Instantiate a struct and initialize all of it's members

            foreach(var day in Enum.GetValues(typeof(MyEnum)))
            {
                Console.WriteLine(day);
            }

            var pointA = new PointA(5.00, 5.00);

            var pointB = new PointB();
            pointB.X = 10.00;
            pointB.Y = 10.00;
            

        }

    }
}

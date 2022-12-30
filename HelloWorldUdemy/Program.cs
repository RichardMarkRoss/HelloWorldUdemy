using System;
using System.Globalization;

namespace HelloWorldUdemy
{

    public class Program
    {
        //entry point of the program

        //sbyte = -128 to 127
        //short = -32767 to 32767
        //int = 2000000000
        //long = 9000000000000000000
        //float = 99.99f (1.5x10^-45 to 3.4x10^38)
        //double = 1.5 15-digit precision
        //decimal = 28-digit precision
        //bool =  false
        //char = single letter 'A' or unicode
        //string = "name" 

        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        // Create a constant of type string with your birthday as its value
        const string birthday = "29.01.1996";
        static void MyTypesMethod()
        {
            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 / d2;

            float f1 = 0.1f;
            float f2 = 3.5f;
            float f3 = f1 + f2;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine(d1 + " devided by " + d2 + " is " + sumD);
            Console.WriteLine(f1 + " float add by " + f2 + " float is " + f3);
        }

        static void StartingMethod()
        {
            var name = "Richard";
            string message = "my name is ";
            string caseName = name.ToUpper();
            Console.WriteLine(message + caseName + "!");
        }
        static void CodingStandardMethod()
        {
            int age = 22;
            int userAge = 35;
            //comment help describe the if you cannot use descriptive naming conventions
            /* multiple line comment
             * lorus imptum
             */
        }

        static void InputTypeMethod()
        {
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("Enter a String and press enter :");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0} ", readInput);

            Console.Write("Enter a String and press enter :");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0} ", asciiValue);
            Console.ReadKey();
            //Console.Clear();
        }
        static void ImplicitMethod()
        {
            // impicit conversion
            int num = 12390532;
            long bigNum = num;
            Console.WriteLine(bigNum);

            float myFloat = 13.37F;
            double myNewDouble = myFloat;
            Console.WriteLine(myNewDouble);

            double myDouble = 13.37;
            int myInt;
            // explicit conversion
            // cast double to int;
            myInt = (int)myDouble;
            Console.WriteLine(myInt);

            // typeConversion 
            string myString = myDouble.ToString(); // "13.37"
            Console.WriteLine(myString);

            string myFloatString = myFloat.ToString();
            Console.WriteLine(myFloatString);

            bool sunIsShining = false;
            string myBoolString = sunIsShining.ToString();
            Console.WriteLine(myBoolString);
            Console.Read();
        }

        static void ParsingStringMethod()
        {
            string myString = "15";
            string mySecondString = "13";
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            float num3 = float.Parse(stringForFloat, CultureInfo.InvariantCulture.NumberFormat);
            int num4 = Int32.Parse(stringForInt);
            int resultInt = num1 + num2;
            string result = myString + mySecondString;
            Console.WriteLine(num3);
            Console.WriteLine(result);
            Console.WriteLine(resultInt);
            Console.Read();
        }

        static void StringManipulationMethod()
        {
            int age = 26;
            string name = "Richard";
            string job = "Developer";

            //1. string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old");
            Console.WriteLine("\n");

            //2. string fromatting
            //string formatting uses index
            Console.WriteLine("string formatting");
            Console.WriteLine("Hello my name is {0} , I am {1} years old. I'm a {2}", name, age, job);
            Console.WriteLine("\n");

            //3. string interpolation
            //string interpolation uses $ at the start which will allow me to write our variables like this {variableName}
            Console.WriteLine("string formatting");
            Console.WriteLine($"Hello my name is {name} , I am {age} years old. I'm a {job}");
            Console.WriteLine("\n");

            //4. Verbatim strings
            //verbatim strings start with @ and tells the compiler to take the string
            //literally and ignore any space and escape characters like \n
            Console.WriteLine("verbatim strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
            Console.WriteLine("\n");

            //instead of using \\ to write files paths we can verbatim string to amke it easier
            //if you remove the @ you will get an error because \U, \A and \D are not calid escape characters
            Console.WriteLine(@"C:\Users\richardr\Pictures\GIT.png");
            Console.WriteLine(@"You \n have no power here!");
            Console.WriteLine("you were meant to destroy the sith \n not join them!");

            Console.Read();
        }

        static void StringChallengeMethod()
        {
            Console.Write("Enter the String here: ");
            //read first input string
            string input = Console.ReadLine();

            Console.Write("Enter the Char here: ");
            //read first input char
            char searchInput = Console.ReadLine()[0];
            //get the index of teh character from the string
            int searchIndex = input.IndexOf(searchInput);

            Console.WriteLine($"Index of character {searchInput} in String is {searchIndex}");

            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();

            string fullname = string.Concat(firstName, " ", lastName);
            Console.WriteLine($"your full name is {fullname}");
        }
        public static void writeSomething()
        {
            Console.WriteLine($"My birthday is always going to be: {birthday}");
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int age = Console.Read();
            writeSomethingSpecific(firstName, age);
            Console.WriteLine("add: " + add(15, 31));
            Console.WriteLine("subtract: " + subtract(15, 31));
            Console.WriteLine("multiply: " + multiply(15, 31));
            Console.WriteLine("divide: " + divide(15, 31));
        }
        public static void writeSomethingSpecific(string myText, int mystring2)
        {
            Console.WriteLine($"HI, my name is {myText}, I am {mystring2} years old");
        }

        public static int add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static float divide(float num1, float num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            writeSomething();
            //StringChallengeMethod();
            //Console.WriteLine("===================================");
            //StringManipulationMethod();
            //Console.WriteLine("===================================");
            //ParsingStringMethod();
            //Console.WriteLine("===================================");
            //ImplicitMethod();
            //Console.WriteLine("===================================");
            //InputTypeMethod();
            //Console.WriteLine("===================================");
            //StartingMethod();
            //Console.WriteLine("===================================");
            //MyTypesMethod();
            //Console.WriteLine("===================================");
            Console.Read();
        }
    }
}
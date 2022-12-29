using System;
using System.Xml.Linq;

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

        static void StartingMethod() {
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
            Console.WriteLine("You have entered {0} ",readInput);

            Console.Write("Enter a String and press enter :");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0} ", asciiValue);
            Console.ReadKey();
            //Console.Clear();
        }
        static void ImplicitMethod(){
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
            myInt = (int) myDouble;
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

    static void Main(string[] args)
        {
            ImplicitMethod();
            Console.WriteLine("===================================");
            InputTypeMethod();
            Console.WriteLine("===================================");
            StartingMethod();
            Console.WriteLine("===================================");
            MyTypesMethod();
            Console.WriteLine("===================================");
            Console.Read();
        }
    }
}
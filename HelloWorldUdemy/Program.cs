using System;

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
            Console.Read();
        }

        static void StartingMethod() {
            var name = "Richard";
            Console.WriteLine("Hello " + name + "!");
        }

        static void Main(string[] args)
        {
            StartingMethod();
            MyTypesMethod();
            Console.Read();
        }
    }
}
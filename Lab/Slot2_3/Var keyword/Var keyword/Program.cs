using System;

namespace Var_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myInt = 0;
            var myBool = true;
            var myString = "Hello World!";
            var myDouble = 0.5;

            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
            Console.WriteLine("myDouble is a: {0}", myDouble.GetType().Name);
            Console.ReadLine();
        }
    }
}

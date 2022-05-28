using System;

namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string MyString, int MyNumber)
                 MyValues = ("Hello world !", 2050);
            Console.WriteLine($"MyString:{MyValues.MyString}");
            Console.WriteLine($"MyNumber:{MyValues.MyNumber}");
            Console.ReadLine();
        }
    }
}

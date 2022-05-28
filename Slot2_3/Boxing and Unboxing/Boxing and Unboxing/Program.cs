using System;

namespace Boxing_and_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;
            i = 456;
            Console.WriteLine("The value-type value = {0}",i);
            Console.WriteLine("The value-type value = {0}",o);
            Console.ReadLine();
        }
    }
}

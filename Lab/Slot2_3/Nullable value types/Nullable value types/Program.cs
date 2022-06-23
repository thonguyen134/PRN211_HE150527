using System;

namespace Nullable_value_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            if ( a is null)
            {
                Console.WriteLine("a does not have a value");
                a = 2050;
            }
            if( a is int valueOFA)
            {
                Console.WriteLine($"a is {valueOFA}");
            }
            Console.ReadLine();
        }
    }
}

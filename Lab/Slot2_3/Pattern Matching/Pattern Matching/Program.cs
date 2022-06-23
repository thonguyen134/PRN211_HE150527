using System;

namespace Pattern_Matching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input data:");
            int.TryParse(Console.ReadLine(), out int n);
            if(n is int count && count > 0)
            {
                Console.WriteLine(new String('*', count));
            }
            else
            {
                Console.WriteLine("Data invalid.");
            }
            Console.ReadLine();
        }
    }
}

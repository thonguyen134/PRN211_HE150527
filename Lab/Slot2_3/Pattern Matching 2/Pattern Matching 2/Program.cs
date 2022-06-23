using System;

namespace Pattern_Matching_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input data:");
            int.TryParse(Console.ReadLine(), out int n);
            switch (n)
            {
                case int count when count > 0:
                    Console.WriteLine(new String('*', count));
                    break;
                default:
                    Console.WriteLine("Data invalid.");
                    break;
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "**** Welcome to C#.net programming ####";
            Console.WriteLine("{0}", msg);
            //
            for (int i = 0; i < args.Length; i++) {
                Console.WriteLine($"Arg: {args[i]}");
            }
            Console.ReadLine();
                }

    }
}

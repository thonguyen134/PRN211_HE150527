using System;

namespace Discards2
{
    internal class Program
    {
        static (string first, string middle, string last) SplitNames(string fullName)
        {
            string[] strArray = fullName.Split(' '); 
            return (strArray[0], strArray[1], strArray[2]);

        }
        static void Main(string[] args)

        {
            var (first, _, last) = SplitNames("Philip F Japikse");
            Console.WriteLine($"{first}: {last}"); 
            Console.ReadLine();

        }

    }
}

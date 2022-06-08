using System;
using System.IO;

namespace Directory_Class_Demonstration
{
    class Program
    {

        static void Main(string[] args)
        {
            //Get current directory
            string sourceDirectory = Directory.GetCurrentDirectory();
            try
            {
                //Get all files
                var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.*");
            foreach (string currentFile in txtFiles)
                {
                    Console.WriteLine(currentFile);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
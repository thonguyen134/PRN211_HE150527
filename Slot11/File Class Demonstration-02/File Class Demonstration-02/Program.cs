﻿using System;
using System.IO;
namespace File_Class_Demonstration_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"MyData. txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {

                // Create a file to write to.
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }
            string appendText = "This is extra text" + Environment.NewLine;
            File.AppendAllText(path, appendText);
            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
            Console.ReadLine();
        }
    }
    }

﻿using System;

namespace OOP_Interface
{
    public interface IFirst {
        void Print();
        void Display();
    }
    public interface ISecond
    {
        void Print();
    }
    public class MyClass : IFirst, ISecond
    {
        public void Display()
        {
            Console.WriteLine("Display method");
        }

        void IFirst.Print()
        {
            Console.WriteLine("IFirst's Print method.");
        }
        void ISecond.Print()
        {
            Console.WriteLine("ISecond's Print method.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Display();
            IFirst first = obj;
            first.Print();
            ISecond second = obj;
            second.Print();
            Console.ReadLine();
        }
    }
}

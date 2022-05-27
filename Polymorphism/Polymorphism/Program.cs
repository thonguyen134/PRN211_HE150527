using System;
namespace Polymorphism
{
    
    public abstract class Shape
    {
        
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Performing base class Drawing tasks");
        }
        public void Print()
        {
            Console.WriteLine("Perfoming base class Printing tasks");
        }
        public abstract void Display();
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
        public override void Display()
        {
            Console.WriteLine("Display Circle");
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
        public override void Display()
        {
            Console.WriteLine("Display Rectangle");
        }
        public new void Print()
        {
            Console.WriteLine("Print Rectangle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape p = new Circle();
            p.Display();
            p.Draw();
            p = new Rectangle();
            p.Display();
            p.Draw();
            p.Print();
            Console.ReadLine();
        }
    }
}

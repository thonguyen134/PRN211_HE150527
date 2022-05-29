using System;
using System.Collections.Generic;
using static System.Console;
namespace Assignment1_Factories_Method
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("***Factory Method Pattern Demo.***\n");
            List<AnimalFactory> animalFactorieList = new List<AnimalFactory>
            {
                new TigerFactory(),
                new LionFactory()
            };

            foreach (var animal in animalFactorieList)
            {
                animal.CreateAnimal().AboutMe();
            }
            ReadLine();
        }
    }
    //IAnimal Interface 
    public interface IAnimal
    {
        void AboutMe();
    }
    //Lion class
    public class Lion : IAnimal
    {
        public void AboutMe() => WriteLine("This is lion.");

    }
    //Tiger class
    public class Tiger : IAnimal
    {
        public void AboutMe() => WriteLine("This is tiger.");

    }
    /// <summary>
    /// 
    /// </summary>
    //AnimalFactory abstract class 
    public abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }
    //LionFactory class 
    public class LionFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Lion();
    }
    //TigerFactory class 
    public class TigerFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Tiger();
        
    }
    
}

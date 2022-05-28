using System;
using System.Collections.Generic;
using static System.Console;
namespace Assignment1_Factories_Method
{
    public interface IAnimal
    {
        void AboutMe();
    }
    //lion class
    public class Lion : IAnimal
    {
        public void AboutMe() => WriteLine("This is lion.");

    }
    public class Tiger : IAnimal
    {
        public void AboutMe() => WriteLine("This is tiger.");

    }
    /// <summary>
    /// 
    /// </summary>
    public abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }
    public class LionFactory : AnimalFactory
    {

        public override IAnimal CreateAnimal() => new Lion();
    }

    public class TigerFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Tiger();
        
    }
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
}

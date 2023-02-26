
using DP01_Creational_AbstractFactory.Implementations;
using DP01_Creational_AbstractFactory.Interfaces;

namespace DP01_Creational_AbstractFactory
{
    public static class Main
    {
        public static void Execute()
        {
            Console.WriteLine("Creating new Concrete Factory 1\n");

            AbstractFactory Factory1 = new ConcreteFactory1();

            Console.WriteLine("Creating Product A from Factory 1");
            AbstractProductA ProductA1 = Factory1.CreateProductA();
            Console.WriteLine($"ProductA = {ProductA1.Name}");

            Console.WriteLine("Creating Product B from Factory 1");
            AbstractProductB ProductB1 = Factory1.CreateProductB();
            Console.WriteLine($"ProductB = {ProductB1.Name}\n");

            Console.WriteLine("Creating new Concrete Factory 2\n");

            AbstractFactory Factory2 = new ConcreteFactory2();

            Console.WriteLine("Creating Product A from Factory 2");
            AbstractProductA ProductA2 = Factory2.CreateProductA();
            Console.WriteLine($"ProductA = {ProductA2.Name}");

            Console.WriteLine("Creating Product B from Factory 2");
            AbstractProductB ProductB2 = Factory2.CreateProductB();
            Console.WriteLine($"ProductB = {ProductB2.Name}\n");
        }
    }
}

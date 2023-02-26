using DP01_Creational_AbstractFactory.Interfaces;

namespace DP01_Creational_AbstractFactory.Implementations
{
    internal class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            AbstractProductA ProductA1 = new ConcreteProductA1();
            return ProductA1;
        }

        public override AbstractProductB CreateProductB()
        {
            AbstractProductB ProductB1 = new ConcreteProductB1();
            return ProductB1;
        }
    }
}

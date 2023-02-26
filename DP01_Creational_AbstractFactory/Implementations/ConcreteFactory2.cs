using DP01_Creational_AbstractFactory.Interfaces;

namespace DP01_Creational_AbstractFactory.Implementations
{
    internal class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            AbstractProductA ProductA2 = new ConcreteProductA2();
            return ProductA2;
        }

        public override AbstractProductB CreateProductB()
        {
            AbstractProductB ProductB2 = new ConcreteProductB2();
            return ProductB2;
        }
    }
}

using DP03_Creational_FactoryMethod.Interfaces;

namespace DP03_Creational_FactoryMethod.Implementations
{
    public class Product1 : Product_abstract
    {
        public Product1(string name) : base(name)
        {
            Console.WriteLine($"Product1 created. Name: {Name}, Status: {Status}.");
        }
    }
}

using DP03_Creational_FactoryMethod.Interfaces;

namespace DP03_Creational_FactoryMethod.Implementations
{
    public class Product2 : Product_abstract
    {
        public Product2(string name) : base(name)
        {
            Console.WriteLine($"Product2 created. Name: {Name}, Status: {Status}.");
        }
    }
}

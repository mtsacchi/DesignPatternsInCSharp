using DP03_Creational_FactoryMethod.Interfaces;

namespace DP03_Creational_FactoryMethod.Implementations
{
    public class Creator1 : Creator_abstract
    {
        public override IProduct CreateProduct()
        {
            return new Product1("Product1");
        }
    }
}

using DP03_Creational_FactoryMethod.Interfaces;
using DP03_Creational_FactoryMethod.Implementations;

namespace DesignPatternsInCSharp.DP03_Creational_FactoryMethod
{
    public static class Main
    {
        public static void Execute()
        {
            Console.WriteLine("Creating Creator1");
            ICreator Creator1 = new Creator1();
            Console.WriteLine("Creating Product1");
            IProduct Product1 = Creator1.CreateProduct();

            Console.WriteLine("Creating Creator2");
            ICreator Creator2 = new Creator2();
            Console.WriteLine("Creating Product2");
            IProduct Product2 = Creator2.CreateProduct();

        }
    }
}

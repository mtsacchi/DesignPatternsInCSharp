namespace DP03_Creational_FactoryMethod.Interfaces
{
    public interface IProduct
    {
        string Name { get; }
        string Status { get; }

        void Open();
        void Close();
    }
}

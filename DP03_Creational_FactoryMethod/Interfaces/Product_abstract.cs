namespace DP03_Creational_FactoryMethod.Interfaces
{
    public abstract class Product_abstract : IProduct
    {
        public string Name { get; private set; }
        public string Status { get; private set; }

        public virtual void Open()
        {
            Status = "Opened";
        }

        public virtual void Close()
        {
            Status = "Closed";
        }

        public Product_abstract(string name)
        {
            Name = name;
            Open();
        }
    }
}

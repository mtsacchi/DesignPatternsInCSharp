namespace DesignPatternsInCSharp.DP04_Creational_Prototype.Interfaces
{
    public interface IGraphic<T>
    {
        Guid Id { get; }
        string Name { get; set; }
        T Clone();
    }
}

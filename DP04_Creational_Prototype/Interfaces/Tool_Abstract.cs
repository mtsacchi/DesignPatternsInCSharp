namespace DesignPatternsInCSharp.DP04_Creational_Prototype.Interfaces
{
    public abstract class Tool_Abstract<T>
    {
        public abstract T prototype { get; protected set; }
        public abstract T Execute();
        public Tool_Abstract() { }
    }
}

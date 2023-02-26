using DesignPatternsInCSharp.DP04_Creational_Prototype.Interfaces;

namespace DesignPatternsInCSharp.DP04_Creational_Prototype.Implementations
{
    public class GraphicStaff : IGraphic<GraphicStaff> 
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }

        public GraphicStaff Clone()
        {
            GraphicStaff dest = new GraphicStaff(this);
            return dest;
        }

        public GraphicStaff()
        {   
            Id = Guid.NewGuid();
            Name = "Staff prototype";

            Console.WriteLine($"Constructor Id:{Id}, Name:{Name}");
        }

        public GraphicStaff(GraphicStaff source)
        {
            Id = source.Id;
            Name = source.Name;
        }
    }
}

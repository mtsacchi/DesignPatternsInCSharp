using DesignPatternsInCSharp.DP04_Creational_Prototype.Interfaces;

namespace DesignPatternsInCSharp.DP04_Creational_Prototype.Implementations
{
    public class GraphicHalfNote : IGraphic<GraphicHalfNote>
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }

        public GraphicHalfNote Clone()
        {
            GraphicHalfNote dest = new GraphicHalfNote(this);
            return dest;
        }

        public GraphicHalfNote()
        {
            Id = Guid.NewGuid();
            Name = "Half Note prototype";

            Console.WriteLine($"Constructor Id:{Id}, Name:{Name}");
        }

        public GraphicHalfNote(GraphicHalfNote source)
        {
            Id = source.Id;
            Name = source.Name;
        }
    }
}

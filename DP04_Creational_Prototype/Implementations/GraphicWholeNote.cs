using DesignPatternsInCSharp.DP04_Creational_Prototype.Interfaces;

namespace DesignPatternsInCSharp.DP04_Creational_Prototype.Implementations
{
    public class GraphicWholeNote : IGraphic<GraphicWholeNote>
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }

        public GraphicWholeNote Clone()
        {
            GraphicWholeNote dest = new GraphicWholeNote(this);
            return dest;
        }

        public GraphicWholeNote()
        {
            Id = Guid.NewGuid();
            Name = "Whole Note prototype";

            Console.WriteLine($"Constructor Id:{Id}, Name:{Name}");
        }

        public GraphicWholeNote(GraphicWholeNote source)
        {
            Id = source.Id;
            Name = source.Name;
        }
    }
}

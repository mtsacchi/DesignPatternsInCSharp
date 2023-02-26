using DesignPatternsInCSharp.DP04_Creational_Prototype.Interfaces;

namespace DesignPatternsInCSharp.DP04_Creational_Prototype.Implementations
{
    public class CreationTool_Staff : Tool_Abstract<GraphicStaff>
    {
        public override GraphicStaff prototype { get; protected set; }

        public override GraphicStaff Execute()
        {
            return prototype.Clone();
        }

        public CreationTool_Staff()
        {
            prototype = new GraphicStaff();
        }
    }

    public class CreationTool_WholeNote : Tool_Abstract<GraphicWholeNote>
    {
        public override GraphicWholeNote prototype { get; protected set; }

        public override GraphicWholeNote Execute()
        {
            return prototype.Clone();
        }

        public CreationTool_WholeNote()
        {
            prototype = new GraphicWholeNote();
        }
    }

    public class CreationTool_HalfNote : Tool_Abstract<GraphicHalfNote>
    {
        public override GraphicHalfNote prototype { get; protected set; }

        public override GraphicHalfNote Execute()
        {
            return prototype.Clone();
        }

        public CreationTool_HalfNote()
        {
            prototype = new GraphicHalfNote();
        }
    }

}

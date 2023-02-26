using DesignPatternsInCSharp.DP04_Creational_Prototype.Implementations;

namespace DesignPatternsInCSharp.DP04_Creational_Prototype
{
    public static class Main
    {
        public static void Execute()
        {
            CreationTool_Staff ToolCreateStaff = new CreationTool_Staff();
            CreationTool_WholeNote ToolCreateWholeNote = new CreationTool_WholeNote();
            CreationTool_HalfNote ToolCreateHalfNote = new CreationTool_HalfNote();

            GraphicStaff s1 = ToolCreateStaff.Execute();
            GraphicStaff s2 = ToolCreateStaff.Execute();
            
            s1.Name = "s1";
            s2.Name = "s2";
            
            Console.WriteLine($"s1 Id:{s1.Id}, Name:{s1.Name}");
            Console.WriteLine($"s2 Id:{s2.Id}, Name:{s2.Name}");

            GraphicWholeNote w1 = ToolCreateWholeNote.Execute();
            GraphicWholeNote w2 = ToolCreateWholeNote.Execute();

            w1.Name = "w1";
            w2.Name = "w2";

            Console.WriteLine($"w1 Id:{w1.Id}, Name:{w1.Name}");
            Console.WriteLine($"w2 Id:{w2.Id}, Name:{w2.Name}");

            GraphicHalfNote h1 = ToolCreateHalfNote.Execute();
            GraphicHalfNote h2 = ToolCreateHalfNote.Execute();

            h1.Name = "h1";
            h2.Name = "h2";

            Console.WriteLine($"h1 Id:{h1.Id}, Name:{h1.Name}");
            Console.WriteLine($"h2 Id:{h2.Id}, Name:{h2.Name}");
        }
    }
}

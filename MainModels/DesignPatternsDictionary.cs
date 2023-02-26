using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_DesignPatterns.Other
{
    public class DesignPatternsDictionary
    {
        public Dictionary<int, string> Patterns { get; private set; } = new Dictionary<int, string>();

        public DesignPatternsDictionary()
        {
            Patterns.Add(1, "Creational Pattern: AbstractFactory\n" +
                "\t-> Intent: Provide an interface for creating families of related or dependent objects\n" +
                "\t\twithout specifying their concrete classes.\n");

            Patterns.Add(2, "Creational Pattern: Builder\n");
            Patterns.Add(3, "Creational Pattern: FactoryMethod\n");
            Patterns.Add(4, "Creational Pattern: Prototype\n");
            Patterns.Add(5, "Creational Pattern: Singleton\n");

            Patterns.Add(6, "Structural Pattern: Adapter\n");
            Patterns.Add(7, "Structural Pattern: Bridge\n");
            Patterns.Add(8, "Structural Pattern: Composite\n");
            Patterns.Add(9, "Structural Pattern: Decorator\n");
            Patterns.Add(10, "Structural Pattern: Facade\n");
            Patterns.Add(11, "Structural Pattern: Flyweight\n");
            Patterns.Add(12, "Structural Pattern: Proxy\n");

            Patterns.Add(13, "Behavioral Pattern: ChainOfResponsibility\n");
            Patterns.Add(14, "Behavioral Pattern: Command\n");
            Patterns.Add(15, "Behavioral Pattern: Interpreter\n");
            Patterns.Add(16, "Behavioral Pattern: Iterator\n");
            Patterns.Add(17, "Behavioral Pattern: Mediator\n");
            Patterns.Add(18, "Behavioral Pattern: Memento\n");
            Patterns.Add(19, "Behavioral Pattern: Observer\n");
            Patterns.Add(20, "Behavioral Pattern: State\n");
            Patterns.Add(21, "Behavioral Pattern: Strategy\n");
            Patterns.Add(22, "Behavioral Pattern: TemplateMethod\n");
            Patterns.Add(23, "Behavioral Pattern: Visitor\n");
        }
    }
}

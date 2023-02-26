using Estudo_DesignPatterns.Other;

namespace DesignPatternsInCSharp
{
    class Program
    {
        static DesignPatternsDictionary patternsDictionary = new DesignPatternsDictionary();

        static void Main(string[] args)
        {

            while (true)
            {
                bool validItem = false;
                int key = 1;
                string message = "";

                Console.WriteLine("\nSelect the Design Pattern:");
                do
                {
                    message = "";

                    validItem = patternsDictionary.Patterns.TryGetValue(key, out message);
                    if (validItem) Console.WriteLine($"Option {key}: {message}");
                    key++;

                } while (validItem);

                Console.WriteLine();
                string line = Console.ReadLine();
                int.TryParse(line, out int option);

                validItem = GetPatternName(option);

                message = "";

                switch (option)
                {
                    case 1: //"Creational Pattern: Abstract Factory"
                        DP01_Creational_AbstractFactory.Main.Execute();
                        break;
                    case 2: //"Creational Pattern: Builder"
                        DP02_Creational_Builder.Main.Execute();
                        break;
                    default:
                        Console.WriteLine($"Option is invalid or not implemented yet.\n");
                        break;
                }
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
            }
        }

        private static bool GetPatternName(int option)
        {
            bool validItem = patternsDictionary.Patterns.TryGetValue(option, out string message);
            if (validItem)
            {
                Console.WriteLine($"Option {option} selected:\n");
            }
            return validItem;
        }
    }
}


using System;

namespace VisitorPattern
{
    public class ConsoleOutput : ICommandVisitor<int>
    {
        public TU Visit<TU>(Rubi command)
        {
            Console.WriteLine($"[Console] {command.rubi}");
            return default;
        }

        public TU Visit<TU>(ConsoleString command)
        {
            Console.WriteLine($"[Console] {command.text}");
            return default;
        }
    }
}
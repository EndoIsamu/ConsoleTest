using System;

namespace VisitorPattern
{
    public class ConsoleOutput : ICommandVisitor<ConsoleString>
    {
        public void Visit(ConsoleString command)
        {
            Console.WriteLine($"[Console] {command.text}");
        }
    }
}
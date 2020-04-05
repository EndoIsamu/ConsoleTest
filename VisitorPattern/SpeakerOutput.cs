using System;

namespace VisitorPattern
{
    public class SpeakerOutput : ICommandVisitor<string>
    {
        public TU Visit<TU>(Rubi command)
        {
            Console.WriteLine($"[Speaker] {command.rubi}");
            return default;
        }

        public TU Visit<TU>(ConsoleString command)
        {
            Console.WriteLine($"[Speaker] {command.text}");
            return default;
        }
    }
}
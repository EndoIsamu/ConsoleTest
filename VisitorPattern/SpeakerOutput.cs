using System;

namespace VisitorPattern
{
    public class SpeakerOutput : ICommandVisitor<Rubi>
    {
        public void Visit(Rubi command)
        {
            Console.WriteLine($"[Speaker] {command.rubi}");
        }
    }
}
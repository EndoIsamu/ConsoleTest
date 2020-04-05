namespace VisitorPattern
{
    public class ConsoleString : ICommand<ConsoleString>
    {
        public readonly string text;
        
        public ConsoleString(string text)
        {
            this.text = text;
        }

        public void Accept(ICommandVisitor<ConsoleString> commandVisitor)
        {
            commandVisitor.Visit(this);
        }
    }
}
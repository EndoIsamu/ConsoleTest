namespace VisitorPattern
{
    public class ConsoleString : ICommand
    {
        public readonly string text;
        
        public ConsoleString(string text)
        {
            this.text = text;
        }

        public T Accept<T>(ICommandVisitor<T> commandVisitor)
        {
            return commandVisitor.Visit<T>(this);
        }
    }
}
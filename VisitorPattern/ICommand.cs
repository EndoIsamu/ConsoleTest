namespace VisitorPattern
{
    public interface ICommand
    {
        T Accept<T>(ICommandVisitor<T> commandVisitor);
    }
}
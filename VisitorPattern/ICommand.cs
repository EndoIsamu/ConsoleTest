namespace VisitorPattern
{
    public interface ICommand<out T>
    {
        void Accept(ICommandVisitor<T> commandVisitor);
    }
}
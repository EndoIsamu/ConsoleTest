namespace VisitorPattern
{
    public class MotionCommand : ICommand<MotionCommand>
    {
        public void Accept(ICommandVisitor<MotionCommand> commandVisitor)
        {
            commandVisitor.Visit(this);
        }
    }
}
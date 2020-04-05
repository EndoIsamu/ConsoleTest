namespace VisitorPattern
{
    public class Rubi : ICommand<Rubi>
    {
        public readonly string rubi;
        
        public Rubi(string rubi)
        {
            this.rubi = rubi;
        }

        public void Accept(ICommandVisitor<Rubi> commandVisitor)
        {
            commandVisitor.Visit(this);
        }
    }
}
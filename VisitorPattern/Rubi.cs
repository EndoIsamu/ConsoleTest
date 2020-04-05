namespace VisitorPattern
{
    public class Rubi
    {
        public readonly string rubi;
        
        public Rubi(string rubi)
        {
            this.rubi = rubi;
        }

        public T Accept<T>(ICommandVisitor<T> commandVisitor)
        {
            return commandVisitor.Visit<T>(this);
        }
    }
}
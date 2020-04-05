namespace VisitorPattern
{
    /// <summary>
    /// ICommandがデータなのに対し、こちらは処理を記述するクラス
    /// </summary>
    public interface ICommandVisitor<T>
    {
        TU Visit<TU>(Rubi command);
        TU Visit<TU>(ConsoleString command);
    }
}
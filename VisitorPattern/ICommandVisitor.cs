namespace VisitorPattern
{
    /// <summary>
    /// ICommandがデータなのに対し、こちらは処理を記述するクラス
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICommandVisitor<in T>
    {
        void Visit(T command);
    }
}
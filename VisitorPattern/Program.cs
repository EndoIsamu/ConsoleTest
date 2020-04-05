namespace VisitorPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var co = new ConsoleOutput();
            var so = new SpeakerOutput();

            var displayText = new ConsoleString("J1の試合が凄かったですよ");
            var rubi = new Rubi("じぇーわんの試合が凄かったですよ");

            displayText.Accept(co);
            displayText.Accept(so);
            rubi.Accept(co);
            rubi.Accept(so);
        }
    }
}
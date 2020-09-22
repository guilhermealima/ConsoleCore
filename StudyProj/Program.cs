using StudyProj.lib;

namespace StudyProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new GoodGame(
                new Player1("Neymar"),
                new Player2()); 
            game.StartGame();
        }
    }
}

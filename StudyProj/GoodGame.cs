using StudyProj.Interface;

namespace StudyProj
{
    public class GoodGame
    {
        private readonly iPlayer _player;
        private readonly iPlayer _player2;

        public GoodGame(iPlayer player, iPlayer player2)
        {
            _player = player;
            _player2 = player2;
        }
        public void StartGame()
        {
            System.Console.Write(_player.Run());
            System.Console.Write(_player.Kick());
            System.Console.Write(_player.Pass());
            //
            System.Console.Write("\n PRÓXIMO JOGADOR \n");
            //
            System.Console.Write(_player2.Run());
            System.Console.Write(_player2.Kick());
            System.Console.Write(_player2.Pass());
        }
    }
}
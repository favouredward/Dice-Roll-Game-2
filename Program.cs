
namespace Dice_Roll_Game_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(maxAttempts: 3);

            game.Start();
        }
    }
}
namespace Dice_Roll_Game_2
{
    internal class Dice
    {
        private Random random;
        //private Dice dice;
        public Dice()
        {
            random = new Random();
        }

        public int Roll()
        {
           return random.Next(1, 7);
        }
    }

   
}

namespace RocksAndScissors
{
    class GameComponents
    {
        // Game Moves
        public static GameMove Rock = new GameMove(0);
        public static GameMove Paper = new GameMove(1);
        public static GameMove Scissor = new GameMove(2);
        public static GameMove Lizard = new GameMove(3);
        public static GameMove Spock = new GameMove(4);

        // Game Results
        public static GameResult Draw = new GameResult(0, "Draw");
        public static GameResult Win = new GameResult(1, "Win");
        public static GameResult Loose = new GameResult(-1, "Loose");

        public static GameResult Eval(GameMove move1, GameMove move2)
        {
            // Rock Vs. ###
            if(move1.Equals(Rock))
            {
                if (move2.Equals(Rock)) return Draw;
                else if (move2.Equals(Paper)) return Loose;
                else if (move2.Equals(Scissor)) return Win;
                else if (move2.Equals(Spock)) return Loose;
                else if (move2.Equals(Lizard)) return Win;
            }
            else if (move1.Equals(Paper))
            {
                if (move2.Equals(Rock)) return Win;
                else if (move2.Equals(Paper)) return Draw;
                else if (move2.Equals(Scissor)) return Loose;
                else if (move2.Equals(Lizard)) return Loose;
                else if (move2.Equals(Spock)) return Win;
            }
            else if (move1.Equals(Scissor))
            {
                if (move2.Equals(Rock)) return Loose;
                else if (move2.Equals(Paper)) return Win;
                else if (move2.Equals(Scissor)) return Draw;
                else if (move2.Equals(Lizard)) return Win;
                else if (move2.Equals(Spock)) return Loose;
            }
            else if (move1.Equals(Lizard))
            {
                if (move2.Equals(Rock)) return Loose;
                else if (move2.Equals(Paper)) return Win;
                else if (move2.Equals(Scissor)) return Loose;
                else if (move2.Equals(Lizard)) return Draw;
                else if (move2.Equals(Spock)) return Win;
            }
            else if (move1.Equals(Spock))
            {
                if (move2.Equals(Rock)) return Win;
                else if (move2.Equals(Paper)) return Loose;
                else if (move2.Equals(Scissor)) return Win;
                else if (move2.Equals(Lizard)) return Loose;
                else if (move2.Equals(Spock)) return Draw;
            }

            return new GameResult(null , "Unknown Result");
        }
    }
}

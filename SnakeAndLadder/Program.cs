using System;

namespace SnakeAndLadder
{
    class Program
    {
        static int PlayOptions(int diceRoll, int dicePostion, int option , int endPosition)
        {
            switch (option)
            {
                case 0:
                    dicePostion -= diceRoll;
                    break;
                case 1:
                    dicePostion += diceRoll;
                    break;
                default:
                    break;
            }
            return CheckEndPosition(dicePostion,endPosition,diceRoll);
        }

        static int RandomValueGenerator( int start, int end)
        {
            Random random = new Random();
            int rand = random.Next(start, end);
            return rand;
        }

        static int CheckEndPosition(int playerPositionReached, int END_POSITION, int playerDiceRoll)
        {
            if (playerPositionReached > END_POSITION)
            {
                playerPositionReached -= playerDiceRoll;
            }
            return playerPositionReached;
        }
        static void Main(string[] args)
        {
            int START_POSITION = 0;
            int END_POSITION = 100;
            Console.WriteLine("Welcome to Snake and Ladder Game");

            string[] chooseOption = { "Snake", "Ladder", "Noplay" };

            int playerOnePositionReached = START_POSITION;
            int playerTwoPositionReached = START_POSITION;

            while (true)
            {
                if (playerOnePositionReached < START_POSITION)
                {
                    playerOnePositionReached = START_POSITION;
                }
                else if (playerTwoPositionReached < START_POSITION)
                {
                    playerTwoPositionReached = START_POSITION;
                }

                int player1DiceRoll = RandomValueGenerator(1, 7);
                Console.WriteLine("Player 1 dice value is :" + player1DiceRoll);

                int player1_Option = RandomValueGenerator(0, 3);
                Console.WriteLine("Player 1 got:" + chooseOption[player1_Option] + "\n");

                int player2DiceRoll = RandomValueGenerator(1, 7);
                Console.WriteLine("Player 2 dice value is :" + player2DiceRoll);

                int player2_Option = RandomValueGenerator(0, 3);
                Console.WriteLine("Player 2 got:" + chooseOption[player2_Option] + "\n");

                playerOnePositionReached = PlayOptions(player1DiceRoll, playerOnePositionReached, player1_Option , END_POSITION);
                Console.WriteLine("Position reached by player 1 after dice roll: " + playerOnePositionReached);

                playerTwoPositionReached = PlayOptions(player2DiceRoll, playerTwoPositionReached, player2_Option, END_POSITION);
                Console.WriteLine("Position reached by player 2 after dice roll: " + playerTwoPositionReached + "\n");

                if (playerOnePositionReached == END_POSITION) 
                {
                    Console.WriteLine("Player 1 have reached to :" + playerOnePositionReached + "\n ***PLAYER 1 WON THE GAME***");
                    break;
                }
                else if (playerTwoPositionReached == END_POSITION)
                {
                    Console.WriteLine("Player 2 have reached to :" + playerTwoPositionReached + "\n ***PLAYER 2 WON THE GAME***");
                    break;
                }
                
            }
            Console.ReadLine();
        }
    }
}

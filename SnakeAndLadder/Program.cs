using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class Program
    {
        static int PlayOptions(int diceRoll, int dicePostion, int option)
        {
            switch (option)
            {
                case 0:
                    dicePostion = dicePostion - diceRoll;
                    break;

                case 1:
                    dicePostion = dicePostion + diceRoll;
                    break;

                default:
                    break;

            }
            return dicePostion;
        }

        static void Main(string[] args)
        {

            int START_POSITION= 0;
            int END_POSITION = 100;

            Random random = new Random();

            string[] chooseOption = { "Snake", "Ladder", "Noplay" };

            int positionReched = START_POSITION;
            int count = 0;
            while (positionReched != END_POSITION)
            {
                if (positionReched < START_POSITION)
                {
                    positionReched = START_POSITION; 
                }

                int diceRoll = random.Next(1, 7);
                Console.WriteLine("Your dice value is :" + diceRoll);

                int option = random.Next(0, 3);
                Console.WriteLine("You got:" + chooseOption[option]);

                positionReched = PlayOptions(diceRoll, positionReched, option);

                if(positionReched> END_POSITION)
                {
                    positionReched = positionReched - diceRoll;
                   
                }
                Console.WriteLine("Dice Position after the dice roll is:" + positionReched);

                count++;
            }
            
            Console.WriteLine("you have reached to :" + positionReched +"\n ***You Won***");
            Console.WriteLine("You have taken " + count + " turns to win the game.");

            Console.ReadLine();
        }
    }
}

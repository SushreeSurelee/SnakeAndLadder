using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class Program
    {
        static int PlayOptions(int diceRoll, int dicePosition, int option)
        {
            switch (option)
            {
                case 0:
                    dicePosition = dicePosition - diceRoll;
                    break;

                case 1:
                    dicePosition = dicePosition + diceRoll;
                    break;

                default:
                    dicePosition = dicePosition;
                    break;

            }
            return dicePosition;
        }

        static void Main(string[] args)
        {

            int START_POSITION= 0;

            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            Console.WriteLine("Your dice value is :"+diceRoll);

            int option = random.Next(0, 3);
           
            int dicePosition = START_POSITION;
            dicePosition = PlayOptions(diceRoll, dicePosition, option);
            Console.WriteLine("Dice Position after the dice roll is:" + dicePosition);

            Console.ReadLine();
        }
    }
}

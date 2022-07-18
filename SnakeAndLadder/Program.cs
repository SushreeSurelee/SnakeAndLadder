using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {

            int START_POSITION= 0;

            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            Console.WriteLine("Your dice value is :"+diceRoll);
            Console.ReadLine();
        }
    }
}

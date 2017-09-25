using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingsSpelLib
{
    public class Game
    {
        public int Dice1;
        public int Dice2;
        public bool YouAreAWinner;


        public int ThrowDice(int dice1, int dice2)
        {
            Dice1 = dice1;
            Dice2 = dice2;

            var res = dice1 + dice2;
            if (res == 7)
            {
                YouAreAWinner = true;
            }
            else
            {
                throw new Exception("Please try one more time");
            }
                
            return res;
        }
    }
}

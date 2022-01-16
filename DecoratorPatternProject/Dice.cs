using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternProject
{
    internal class Dice : DiceInterface
    {
        public string ThrowDice()
        {
            Random random = new Random();
            System.Int32 diceNum = random.Next(1, 20);
            String output = diceNum.ToString();
            return output;
        }
    }
}

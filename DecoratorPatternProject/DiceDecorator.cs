using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternProject
{
    internal class DiceDecorator : DiceInterface
    {
        private DiceInterface dice;
        public DiceDecorator(DiceInterface dice) 
        {
            this.dice = dice;
        }

        public string ThrowDice()
        {
            return this.dice.ThrowDice();
        }
    }
}

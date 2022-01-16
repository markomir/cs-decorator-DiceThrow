using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternProject
{
    internal class BonusDice : DiceDecorator
    {
        private string bonus;
        public BonusDice(DiceInterface dice, string bonus) : base(dice)
        {
            
            this.bonus = bonus;
        }
        public string ThrowDice()
        {
            
            String output =base.ThrowDice();
            return output + bonus;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class DiceRoller
    {
        public List <DiceRoll> Roll(List<Dice> dices)
        {
            var result = new List<DiceRoll>();
            foreach (var dice in dices)
                result.Add(new DiceRoll(dice.Description, dice.Roll()));
            return result;
        }
    }
}

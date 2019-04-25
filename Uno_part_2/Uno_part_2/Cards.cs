using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno_part_2
{
    public class Cards : List<Cards>, ICloneable
    {
        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        public object Clone()
        {
            Cards newCards = new Cards();
            foreach (Cards sourceCard in this)
            {
                newCards.Add((Cards)sourceCard.Clone());
            }

            return newCards;
        }
    }
}

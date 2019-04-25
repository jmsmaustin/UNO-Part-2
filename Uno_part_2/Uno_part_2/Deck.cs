using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    public class Deck
    {
        private Cards cards = new Cards();

        public Deck()
        {
            for (int colorVal = 0; colorVal < 4; colorVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards.Add(new Card((Color)colorVal, (Rank)rankVal);
                }
            }
        }
        
    }
}

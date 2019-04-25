using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno_part_2
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
                    cards.Add(new Cards((Color)colorVal, (Rank)rankVal));
                }
            }
        }
        public void Shuffle()
        {
            Random r = new Random();
            List<Cards> cardshuffle = new List<Cards>();
            for (int i = Cards.Count-1; i > 0; --i)
            {
                int n = r.Next(i + 1);
                Cards temp = cardshuffle[i];
                cardshuffle[i] = cardshuffle[n];
                cardshuffle[n] = temp;
            }
            
        }
        public List<Cards> Draw (int count)
        {
            var drawnCards = Cards.Take(count).ToList();
            Cards.RemoveAll(x => drawnCards.Contains(x));
            return drawnCards;
        }
    }
}

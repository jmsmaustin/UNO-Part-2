using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    public class ComputerPlayer  : Player
    {
        private Random random = new Random();

        public override string PlayerName => $"Computer {Index}";

        public void Draw(Deck deck, Card availableCard)
        {
            DrawCard(deck);
        }
    }
}

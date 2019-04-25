using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno_part_2
{
    class Player
    {
        public List<Card> Hand { get; set; }
        public int Position { get; set; }
        public Player()
        {
            Hand = new List<Card>();
        }
    }
}

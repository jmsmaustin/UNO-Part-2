//Mitchell & Perri
//Used the Karli Cards Example from the textbook for reference


using CardClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno_part_2
{
    class Manager
    {
        public List<Player> Player { get; set; }
        public  Deck Drawdeck { get; set; }
        public List<Cards> DiscardPile { get; set; }
    }
}

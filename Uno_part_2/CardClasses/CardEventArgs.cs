//Mitchell & Perri
//Used the Karli Cards Example from the textbook for reference

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    public class CardEventArgs : EventArgs
    {
        public Card Card { get; set; }
    }
}

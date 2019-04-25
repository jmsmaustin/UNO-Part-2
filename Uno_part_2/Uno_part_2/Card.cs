using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno_part_2
{
    public class Cards : ICloneable
    {
        public readonly Rank rank;
        public readonly Color color;

        public static bool useTrumps = false;

        public static Color trump = Color.Red;

        private Card()
        {

        }

        public Card(Color newColor, Rank newRank)
        {
            color = newColor;
            rank = newRank;
        }

        public object Clone() => MemberwiseClone();
        public override string ToString() => 
    }
}

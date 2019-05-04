﻿namespace CardClasses
{
    public class Card
    {
        public readonly Rank rank;
        public readonly Color color;

        private Card()
        {
        }

        public Card(Color newColor, Rank newRank)
        {
            color = newColor;
            rank = newRank;
        }

        public object Clone() => MemberwiseClone();
        public override string ToString() => "The " + rank + " of " + color + "s";

        public static bool operator ==(Card card1, Card card2) => (card1?.color == card2?.color) && (card1?.rank == card2?.rank);

        public static bool operator !=(Card card1, Card card2) => !(card1 == card2);

        public override bool Equals(object card) => this == (Card)card;

        public override int GetHashCode() => 13 * (int)color + (int)rank;

        //    public static bool operator >(Card card1, Card card2)
        //    {
        //        if (card1.color == card2.color)
        //        {
        //            if (isAceHigh)
        //            {
        //                if (card1.rank == Rank.Ace)
        //                {
        //                    if (card2.rank == Rank.Ace)
        //                        return false;
        //                    else
        //                        return true;
        //                }
        //                else
        //                {
        //                    if (card2.rank == Rank.Ace)
        //                        return false;
        //                    else
        //                        return (card1.rank > card2.rank);
        //                }
        //            }
        //            else
        //            {
        //                return (card1.rank > card2.rank);
        //            }
        //        }
        //        else
        //        {
        //            if (useTrumps && (card2.suit == Card.trump))
        //                return false;
        //            else
        //                return true;
        //        }
        //    }

        //    public static bool operator <(Card card1, Card card2) => !(card1 >= card2);

        //    public static bool operator >=(Card card1, Card card2)
        //    {
        //        if (card1.suit == card2.suit)
        //        {
        //            if (isAceHigh)
        //            {
        //                if (card1.rank == Rank.Ace)
        //                {
        //                    return true;
        //                }
        //                else
        //                {
        //                    if (card2.rank == Rank.Ace)
        //                        return false;
        //                    else
        //                        return (card1.rank >= card2.rank);
        //                }
        //            }
        //            else
        //            {
        //                return (card1.rank >= card2.rank);
        //            }
        //        }
        //        else
        //        {
        //            if (useTrumps && (card2.suit == Card.trump))
        //                return false;
        //            else
        //                return true;
        //        }
        //    }

        //    public static bool operator <=(Card card1, Card card2) => !(card1 > card2);
    }
}
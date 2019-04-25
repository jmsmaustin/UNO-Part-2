using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    class Player
    {
        public int Index { get; set; }
        protected Cards Hand { get; set; }
        private string name;
        private PlayerState state;

        public event EventHandler<CardEventArgs> OnCardDiscarded;
        public event EventHandler<PlayerEventArgs> OnPlayerHasWon;

        public PlayerState State
        {
            get { return state; }
            set
            {
                state = value;
                OnPropertyChanged(nameof(State));
            }

        }
        public virtual string PlayerName
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(PlayerName))
            }
        }
        public void DrawCard(Deck deck)
        {
            AddCard(deck.Draw());
        }
        public void DiscardCard(Card card)
        {
            Hand.Remove(card);
            if (HasWon)
                OnPlayerHasWon?.Invoke(this, new PlayerEventArgs { Player = this, State = PlayerState.Winner });
            OnCardDiscarded?.Invoke(this, new CardEventArgs { Card = card });
        }
        public bool HasWon;
        public Cards GetCards() => Hand.Clone() as Cards;
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_counting_sim{
    public class Card
    {
        public Rank Rank { get; set; }
        public Suit Suit { get; set; }

        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public int GetValue()
        {
            switch (Rank)
            {
                case Rank.Ace:
                    return 11;  // Wir berücksichtigen Aces zu Beginn als 11
                case Rank.King:
                case Rank.Queen:
                case Rank.Jack:
                    return 10;
                default:
                    return (int)Rank;  // Die Werte 2-10 entsprechen direkt den Kartennummern
            }
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    public enum Rank
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}


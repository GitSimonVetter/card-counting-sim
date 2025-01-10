using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static card_counting_sim.Card;

namespace card_counting_sim
{
    public class Hand
    {
        public List<Card> Cards { get; private set; }

        public Hand()
        {
            Cards = new List<Card>();
        }

        // Methode zum Hinzufügen einer Karte zur Hand
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        // Berechnet den Gesamtwert der Hand
        public int GetTotalValue()
        {
            int totalValue = 0;
            int aceCount = 0;

            foreach (var card in Cards)
            {
                if (card.Rank == Rank.Ace)
                    aceCount++;
                totalValue += card.GetValue();
            }

            // Berücksichtige die Aces
            while (totalValue > 21 && aceCount > 0)
            {
                totalValue -= 10;  // Wandle Ace von 11 auf 1 um
                aceCount--;
            }

            return totalValue;
        }

        public int GetCardCount()
        {
            return Cards.Count;
        }

        public bool IsBusted()
        {
            return GetTotalValue() > 21;
        }

        public override string ToString()
        {
            return string.Join(", ", Cards);
        }
    }
}

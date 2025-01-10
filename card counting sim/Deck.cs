using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_counting_sim
{
    public class Deck
    {
        public List<Card> Cards { get; private set; }
        private Random random;

        public Deck(int numberOfDecks = 1)
        {
            Cards = new List<Card>();
            random = new Random();
            for (int i = 0; i < numberOfDecks; i++)
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                    {
                        Cards.Add(new Card(rank, suit));
                    }
                }
            }
            Shuffle();
        }

        public void Shuffle()
        {
            Cards = Cards.OrderBy(c => random.Next()).ToList();
        }

        public Card DrawCard()
        {
            if (Cards.Count == 0)
                throw new InvalidOperationException("Das Deck ist leer.");

            var card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            this.Initialize();
        }

        public void Initialize()
        {
            cards = new List<Card>();

            for (int n = 0; n < 4; n++) //loob kaardipaki mastide ja numbritega
            {
                for (int m = 0; m < 13; m++)
                {
                    cards.Add(new Card() { Suit = (Suit)n, Face = (Face)m });

                    if (m <= 8)
                        cards[cards.Count - 1].Value = m + 1;
                    else if (m == 0)
                        cards[cards.Count - 1].Value = 11;
                    else
                        cards[cards.Count - 1].Value = 10;
                }
            }
        }

        public void Shuffle() //segab kaardipaki kasutades Fisher-Yates algoritmi
        {
            Random rnd = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Card card = cards[k];
                cards[k] = cards[n];
                cards[n] = card;
            }
        }

        public Card DrawACard() //võtab kaardipakist kaardi ja eemaldab selle sealt, et keegi uuesti sama kaarti ei saaks
        {
            if (cards.Count <= 0)
            {
                this.Initialize();
                this.Shuffle();
            }

            Card cardToReturn = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            return cardToReturn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deck
    {
        public Stack<Card> Cards = new Stack<Card>();
        Random r = new Random();

        public Deck()
        {
            Cards.Clear();
            while (Cards.Count < 52)
            {
                Card newCard = new Card(r.Next(52));
                if (!Cards.Contains(newCard))
                {
                    Cards.Push(newCard);
                }
            }
        }
    }
}

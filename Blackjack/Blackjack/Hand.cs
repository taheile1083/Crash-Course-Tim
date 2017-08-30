using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Hand
    {
        public Stack<Card> Dealt = new Stack<Card>();
        public int Sum;

        public Hand (Stack<Card> Deck)
        {
            Hit(Deck);
            Hit(Deck);
        }
        public void Hit(Stack<Card> Deck)
        {
            Sum = 0;
            Dealt.Push(Deck.Pop());
            foreach (Card card in Dealt)
            {
                if (card.Value > 10)
                {
                    card.Value = 10;
                }
                if ((card.Value == 1) && (Sum < 11))
                {
                    card.Value = 11;
                }
                Sum += card.Value;
            }
        }
        public bool Blackjack()
        {
            return (Sum == 21);
        }
        public bool Bust()
        {
            return (Sum > 21);
        }
    }
}

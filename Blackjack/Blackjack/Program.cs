using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck testDeck = new Deck();
            Hand player = new Hand(testDeck.Cards);
            Hand dealer = new Hand(testDeck.Cards);
            foreach (Card card in dealer.Dealt) {
                Console.WriteLine(card.Face+card.Suit + " = " +card.Value + " Points.");
            }
            Console.WriteLine("Dealer has " + dealer.Sum + " points.");
            foreach (Card card in player.Dealt)
            {
                Console.WriteLine(card.Face + card.Suit + " = " + card.Value + " Points.");
            }
            Console.WriteLine("You have " + player.Sum + " points.");
            if (dealer.Bust()) {
                Console.WriteLine("Dealer Busts! You Win!");
            } else if (dealer.Blackjack()) {
                Console.WriteLine("Dealer has Blackjack! Dealer Wins");
            } else if (player.Blackjack()) {
                Console.WriteLine("You have a Blackjack! You Win!");
            } else if (player.Bust()) {
                Console.WriteLine("Bust! Dealer Wins.");
            } else {
                if (player.Sum > dealer.Sum)
                {
                    Console.WriteLine("You Win!");
                } else
                {
                    Console.WriteLine("Dealer Wins!");
                }
            }
            Console.Read();
        }
    }
}

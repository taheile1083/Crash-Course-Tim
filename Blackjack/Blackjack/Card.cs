using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Card
    {
        public int CardID;
        public int Value;
        public string Suit;
        public string Face;

        public string[] Suits = {"H","C","D","S"}; //{"♥","♣","♦","♠"};
        public string[] FaceValues = {" A"," 2"," 3"," 4"," 5"," 6"," 7"," 8"," 9","10"," J"," Q"," K"};

        public Card(int ID) {
            CardID = ID;
            Value = CardValue(ID);
            Face = FaceValue(ID);
            Suit = SuitName(ID);
        }

        public int CardValue(int CardID)
        {
            return ((CardID % 13)+1);
        }
        public string SuitName(int CardID)
        {
            return Suits[(CardID / 13)];
        }
        public string FaceValue(int CardID)
        {
            return FaceValues[(CardID % 13)];
        }
    }
}

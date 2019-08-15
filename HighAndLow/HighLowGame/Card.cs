using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighAndLow.HighLowGame
{
    public class Card
    {
        public int value;
        public int suit;

        public Card()
        {
            Random rand = new Random();
            this.value = rand.Next(2, 15);
            this.suit = rand.Next(0, 4); 
        }

        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public string suitString()
        {

            string[] suits = { "Diamond", "Heart", "Spades", "Clubs" };

            return suits[this.suit];
        }

    }
}

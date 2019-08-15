using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighAndLow.HighLowGame
{
    public class HighLowGameSet : Card
    {
        public void GameProcess()
        {

           // Console.WriteLine("This is a test..");

            var firstCard = new Card();
            var secondCard = new Card();

            if(firstCard.value == secondCard.value && firstCard.suit == secondCard.suit)
            {
                var displayNextCard = new Card(); 
            }
            else
            {
                Console.WriteLine("Here's your first card.");
                Console.WriteLine("{0} {1}", firstCard.value, firstCard.suit);
                Console.WriteLine("Now let's play high or low...");




            }

        }
    }
}

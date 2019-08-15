using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighAndLow.HighLowGame
{
    public class HighLowGameSet : Card
    {
        public int correctPick = 0;

        public void GameProcess()
        {

            var firstCard = new Card(2, 0);
            var secondCard = new Card();

            if(firstCard.value == secondCard.value && firstCard.suitString() == secondCard.suitString())
            {
                secondCard = new Card();
            }
            else
            {
                Console.WriteLine("Here's your first card.");
                Console.WriteLine("{0} {1}", firstCard.value, firstCard.suitString());
                Console.WriteLine("Now let's play high or low...");

                string inputGuess = Console.ReadLine();

                if (inputGuess.ToLower() != "high" && inputGuess.ToLower() != "low")
                {
                    Console.WriteLine("Please choose between high or low: ");
                }
                else if
                    (secondCard.value > firstCard.value && inputGuess.ToLower() == "high" || secondCard.value < firstCard.value && inputGuess.ToLower() == "low")
                {
                    Console.WriteLine("Correct! You chose wisely.");
                    correctPick++;
                    secondCard = firstCard;
                    secondCard = new Card();
                    Console.WriteLine("{0}: Let's see how far you go with this streak of yours.", correctPick);
                }
                else if
                    (secondCard.value < firstCard.value && inputGuess.ToLower() == "high" || secondCard.value > firstCard.value && inputGuess.ToLower() == "low")
                {
                    Console.WriteLine("Goodbye, better luck next time");
                    correctPick = 0;
                }
                Console.WriteLine("got to end of system");
            }
        }
    }
}

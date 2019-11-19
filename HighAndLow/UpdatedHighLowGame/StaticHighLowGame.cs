using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighAndLow.UpdatedHighLowGame
{
    public class StaticHighLowGame
    {
        public void SimpleHighAndLow()
        {
            Random randomCard = new Random();
            Console.WriteLine("Based of this card, will next card be high or low?");

            var firstCard = randomCard.Next(1, 14);
            Console.WriteLine(firstCard);

            int secondCard = 7;
            string input = Console.ReadLine();
            Console.WriteLine(secondCard);

            if (secondCard > firstCard && input.ToLower() == "high" || secondCard < firstCard && input.ToLower() == "low")
            {
                Console.WriteLine("Good choice!");
            }

            else if (secondCard < firstCard && input.ToLower() == "high" || secondCard > firstCard && input.ToLower() == "low")
            {
                Console.WriteLine("Incorrect pick, good try!");
            }

            else
            {
                Console.WriteLine("Seems like it ended as a draw.");
            }
        }
    }
}

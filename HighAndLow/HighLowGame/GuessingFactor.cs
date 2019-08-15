using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighAndLow.HighLowGame
{
    public class GuessingFactor
    {
        public void Guess()
        {
            int handPickedCard = 7;
            int randomCard = 7;

            if(handPickedCard > randomCard)
            {
                Console.WriteLine("Win");
            } else if (handPickedCard < randomCard)
            {
                Console.WriteLine("Lost");
            } else
            {
                Console.WriteLine("Draw");
            }

        }
    }
}

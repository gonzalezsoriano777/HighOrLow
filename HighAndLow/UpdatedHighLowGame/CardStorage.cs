using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighAndLow.UpdatedHighLowGame
{
   public class CardStorage
   {
        enum cardSuits { Diamond = 0, Hearts = 1, Spades = 2, Clubs = 3 }

        public void suitRandomizer()
        {
            cardSuits firstCardSuits = (cardSuits)new Random().Next(0, 3);
            Console.WriteLine(firstCardSuits);
        }
    }
}

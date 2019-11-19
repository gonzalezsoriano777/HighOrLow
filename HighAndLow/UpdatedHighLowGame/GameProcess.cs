using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighAndLow.UpdatedHighLowGame
{
    class GameProcess : CardStorage
    {
       
        public void CollectingCards()
        {
            Random randomCard = new Random();
            var firstCardNum = randomCard.Next(1, 14);
            
        }

        public void HighLowCardGame()
        {

        }
    }
}

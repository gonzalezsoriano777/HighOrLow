using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighAndLow.HighLowGame;


namespace HighAndLow
{

    public class Program
    {
        static void Main(string[] args)
        {

            Card aCard = new Card();
            Console.WriteLine("aCard : {0} of {1}", aCard.value, aCard.suitString());
        
            Card myCard = new Card(11, 2);
            Console.WriteLine("myCard : {0} of {1}", myCard.value, myCard.suitString());
            
        }
    }
}

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

            Card myCard = new Card();
            Card aCard = new Card(13, 1);

            Console.WriteLine("aCard : {0} of {1}", aCard.value, aCard.suitString());
            for (int i = 0; i < 5; i++)
            {
                myCard = new Card();
                Console.WriteLine("myCard : {0} of {1}", myCard.value, myCard.suitString());
                Console.ReadLine();
            }
        }
    }
}

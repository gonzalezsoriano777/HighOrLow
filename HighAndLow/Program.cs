﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighAndLow.HighLowGame;
using HighAndLow.BestHand;

namespace HighAndLow
{

    public class Program
    {
        static void Main(string[] args)
        {

            HighLowGameSet cardGame = new HighLowGameSet();
            cardGame.GameProcess();


         //   Deck gameDeck = new Deck();
         //   gameDeck.PickDeck();
        }
    }
}

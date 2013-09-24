using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata1
{
    public class Hand
    {
        public Hand(list PlayerList)
        {
            var playerCards = new List<Card>();
                foreach(var item in PlayerList)
                {
                    playerCards.Add(new Card(item.Substring(0,1), item.Substring(1,1)));
                }
             playerCards.Sort();
        }
    }
}

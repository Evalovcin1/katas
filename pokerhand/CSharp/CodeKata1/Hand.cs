using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata1
{
    public class Hand
    {
        public List<Card> Cards;
        public string PlayerIdentifier;

        
        public Hand(string PlayerList)
        {
            var RawHand = PlayerList.Split(':');
            PlayerIdentifier = RawHand[0];

            Cards = new List<Card>();
            foreach (var item in RawHand[1].Trim().Split(' '))
            {
                Cards.Add(new Card(item.Substring(0, 1), item.Substring(1, 1)));
            }
            Cards.Sort();
        }

        private void methodNAme(string name) { }

         

    }
}

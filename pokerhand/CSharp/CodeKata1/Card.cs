using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata1
{
    class Card
    {
        public Card(string face, string suit)
        {
               switch(face)
                   {case "J":
                        face="11";
                        break;
                    case "Q":
                        face="12";
                        break;
                    case "K":
                        face="13";
                        break;
                    case "A":
                        face="14";
                        break;
                    }
            Face=face;
            Suit = suit;
        }
        public string Face { get; private set; }
        public string Suit { get; private set; }
    }
}
